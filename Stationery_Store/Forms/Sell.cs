using Stationery_Store.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class SellForm : Form
    {
        private Context context = new Context();

        // List of selected products to sell (cart)
        private List<Product> selectedProducts = new List<Product>();

        public SellForm()
        {
            InitializeComponent();
            panel1.Size = this.Size;

            // Disable auto-generating columns for the product grid
            productsGridView.AutoGenerateColumns = false;

            ConfigureProductGrid();
            ConfigureSellGrid();
            SellGridView.CellValueChanged += SellGridView_CellValueChanged;
            SellGridView.EditingControlShowing += SellGridView_EditingControlShowing;

            // Show all products initially
            productsGridView.DataSource = context.Products.Take(50).ToList();

            //Delete product from sell GridView

            Button RemoveBtn = new Button();
            RemoveBtn.Text = "حذف المنتج";
            RemoveBtn.Location = new Point(10, 400); // غير الإحداثيات حسب تصميمك
            RemoveBtn.Click += RemoveBtn_Click_1;
            this.Controls.Add(RemoveBtn);

        }

        /// <summary>
        /// This event triggers when the user types in the search box.
        /// It searches for products containing the typed name and shows them in the product grid.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                productsGridView.DataSource = context.Products.Take(50).ToList();
                return;
            }

            var results = context.Products
                .Where(p => p.Name.Contains(searchTerm))
                .Take(50)
                .ToList();

            productsGridView.DataSource = results;
        }

        /// <summary>
        /// This button adds the selected product from the product grid to the sell grid (cart).
        /// </summary>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (productsGridView.CurrentRow == null)
            {
                MessageBox.Show("من فضلك اختر منتج لإضافته");
                return;
            }

            var selectedProduct = (Product)productsGridView.CurrentRow.DataBoundItem;

            if (selectedProducts.Any(p => p.ID == selectedProduct.ID))
            {
                MessageBox.Show("المنتج مضاف بالفعل في السلة");
                return;
            }

            selectedProducts.Add(selectedProduct);

            if (selectedProducts.Count < 1)
            {
                MessageBox.Show("السلة فارغة");
                return;
            }

            var price = selectedProduct.Price;

            int rowIndex = SellGridView.Rows.Add();
            var row = SellGridView.Rows[rowIndex];
            row.Cells["SellProductId"].Value = selectedProduct.ID;
            row.Cells["SellProductName"].Value = selectedProduct.Name;
            row.Cells["SellQuantity"].Value = 1;
            row.Cells["SellPrice"].Value = price;
        }

        /// <summary>
        /// This button finalizes the sale process and saves the order to the database.
        /// </summary>
        private void SellBtn_Click(object sender, EventArgs e)
        {
            if (SellGridView.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد منتجات للبيع");
                return;
            }

            bool hasError = false;
            decimal totalPrice = 0;
            int totalQuantity = 0;

            Order order = new Order
            {
                Date = DateTime.Now,
                OrderItems = new List<OrderItem>()
            };

            for (int i = 0; i < SellGridView.Rows.Count; i++)
            {
                var row = SellGridView.Rows[i];
                string productName = row.Cells["SellProductName"].Value?.ToString();

                if (!int.TryParse(row.Cells["SellProductId"].Value?.ToString(), out int productId))
                {
                    MessageBox.Show($"رقم المنتج غير صالح: {productName}");
                    hasError = true;
                    continue;
                }

                if (!int.TryParse(row.Cells["SellQuantity"].Value?.ToString(), out int quantity) || quantity <= 0)
                {
                    MessageBox.Show($"برجاء إدخال كمية صحيحة للمنتج: {productName}");
                    hasError = true;
                    continue;
                }

                if (!decimal.TryParse(row.Cells["SellPrice"].Value?.ToString(), out decimal price) || price <= 0)
                {
                    MessageBox.Show($"برجاء إدخال سعر صحيح للمنتج: {productName}");
                    hasError = true;
                    continue;
                }

                var product = context.Products.FirstOrDefault(p => p.ID == productId);
                if (product == null)
                {
                    MessageBox.Show($"المنتج غير موجود في قاعدة البيانات: {productName}");
                    hasError = true;
                    continue;
                }

                if (quantity > product.Quantity)
                {
                    MessageBox.Show($"الكمية المطلوبة غير متاحة للمنتج: {productName}");
                    hasError = true;
                    continue;
                }

                product.Quantity -= quantity;

                OrderItem orderItem = new OrderItem
                {
                    ProductId = productId,
                    ProductName = product.Name, // 👈 خزّن اسم المنتج هنا
                    Quantity = quantity,
                    UnitPrice = (double)price,
                    Product = product,
                    Order = order
                };

                order.OrderItems.Add(orderItem);

                totalPrice += price * quantity;
                totalQuantity += quantity;
            }

            if (hasError)
            {
                return;
            }

            order.TotalAmount = totalQuantity;
            order.TotalPrice = (double)totalPrice;

            context.Orders.Add(order);
            context.SaveChanges();

            MessageBox.Show("تمت عملية البيع بنجاح");
            selectedProducts.Clear();
            SellGridView.Rows.Clear();
            SearchTextBox.Clear();
            productsGridView.DataSource = context.Products.Take(50).ToList();
            UpdateTotalPrice();
            UpdateTotalQuantity();
            InvoiceForm invoiceForm = new InvoiceForm(order);
            invoiceForm.Show();

        }

        private void ConfigureProductGrid()
        {
            productsGridView.Columns.Clear();

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الاسم",
                DataPropertyName = "Name",
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الوصف",
                DataPropertyName = "Description",
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "السعر",
                DataPropertyName = "Price",
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الكمية المتاحة",
                DataPropertyName = "Quantity",
                ReadOnly = true,
            });
        }

        private void ConfigureSellGrid()
        {
            SellGridView.Columns.Clear();

            SellGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SellProductId",
                Visible = false
            });

            SellGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "اسم المنتج",
                Name = "SellProductName",
                ReadOnly = true
            });

            SellGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الكمية",
                Name = "SellQuantity",
                ReadOnly = false
            });

            SellGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "السعر",
                Name = "SellPrice",
                ReadOnly = false
            });
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in SellGridView.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["SellPrice"].Value?.ToString(), out decimal price) &&
                    int.TryParse(row.Cells["SellQuantity"].Value?.ToString(), out int quantity))
                {
                    total += price * quantity;
                }
            }

            TotalPrice.Text = $"الإجمالي: {total} جنيه";
        }

        private void UpdateTotalQuantity()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in SellGridView.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.TryParse(row.Cells["SellQuantity"].Value?.ToString(), out int quantity))
                {
                    total += quantity;
                }
            }

            TotalQuantity.Text = $"الكمية: {total} ";
        }

        private void SellGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.TextChanged -= CellTextChanged;
            e.Control.TextChanged += CellTextChanged;
        }

        private void CellTextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateTotalQuantity();
        }

        private void SellGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                (SellGridView.Columns[e.ColumnIndex].Name == "SellQuantity" ||
                 SellGridView.Columns[e.ColumnIndex].Name == "SellPrice"))
            {
                UpdateTotalPrice();
                UpdateTotalQuantity();
            }
        }

        private void RemoveBtn_Click_1(object sender, EventArgs e)
        {
            if (SellGridView.CurrentRow == null || SellGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("من فضلك اختر صفًا لحذفه");
                return;
            }

            var productId = SellGridView.CurrentRow.Cells["SellProductId"].Value;
            if (productId != null)
            {
                // إحذف المنتج من قائمة المنتجات المحددة
                selectedProducts.RemoveAll(p => p.ID.ToString() == productId.ToString());
            }

            // إحذف الصف من الجريد
            SellGridView.Rows.Remove(SellGridView.CurrentRow);

            // حدّث الإجمالي
            UpdateTotalPrice();
            UpdateTotalQuantity();
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
