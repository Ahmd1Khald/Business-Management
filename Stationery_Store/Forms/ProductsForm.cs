using Stationery_Store.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Stationery_Store.Forms
{
    public partial class ProductsForm : Form
    {
        private Context context = new Context();
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 1;
        private IQueryable<dynamic> filteredQuery;

        public ProductsForm()
        {
            InitializeComponent();
            ConfigureProductGrid();
            LoadCategories();

            stockStatusComboBox.Items.Add(new { Text = "الكل", Value = "All" });
            stockStatusComboBox.Items.Add(new { Text = "متوفر في المخزون", Value = "InStock" });
            stockStatusComboBox.Items.Add(new { Text = "غير متوفر في المخزون", Value = "OutOfStock" });
            stockStatusComboBox.DisplayMember = "Text";
            stockStatusComboBox.ValueMember = "Value";
            stockStatusComboBox.SelectedIndex = 0;

            InitializePaginationControls();
            LoadProducts();

            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            categoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            txtMinPrice.TextChanged += PriceRange_TextChanged;
            txtMaxPrice.TextChanged += PriceRange_TextChanged;
            stockStatusComboBox.SelectedIndexChanged += StockStatus_SelectedIndexChanged;
            productsGridView.Resize += ProductsGridView_Resize;
            this.Resize += ProductsForm_Resize;
            this.Activated += ProductsForm_Activated;

            SetButtonHoverEffects(btnFirst);
            SetButtonHoverEffects(btnPrev);
            SetButtonHoverEffects(btnNext);
            SetButtonHoverEffects(btnLast);
        }

        private void ProductsForm_Activated(object sender, EventArgs e)
        {
            // Reset filters to default state
            searchTextBox.Text = string.Empty;
            categoryComboBox.SelectedIndex = 0; // Assuming 0 is "جميع الأصناف"
            txtMinPrice.Text = string.Empty;
            txtMaxPrice.Text = string.Empty;
            stockStatusComboBox.SelectedIndex = 0; // Assuming 0 is "الكل"

            // Reset pagination to the first page
            currentPage = 1;

            LoadProducts();
            LoadCategories();
        }

        private void ProductsGridView_Resize(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void ProductsForm_Resize(object sender, EventArgs e)
        {
            CenterPaginationPanel();
        }

        private void InitializePaginationControls()
        {
            paginationPanel.Dock = DockStyle.Bottom;
            paginationPanel.Height = 40;
            paginationPanel.BackColor = Color.White;

            btnFirst.Text = "الأول";
            btnPrev.Text = "السابق";
            btnNext.Text = "التالي";
            btnLast.Text = "الأخير";

            lblPageInfo.AutoSize = true;
            lblPageInfo.Text = $"صفحة {currentPage} من {totalPages}";

            btnFirst.Click += (s, e) => { currentPage = 1; LoadProducts(); };
            btnPrev.Click += (s, e) => { if (currentPage > 1) { currentPage--; LoadProducts(); } };
            btnNext.Click += (s, e) => { if (currentPage < totalPages) { currentPage++; LoadProducts(); } };
            btnLast.Click += (s, e) => { currentPage = totalPages; LoadProducts(); };
        }

        private void ConfigureProductGrid()
        {
            productsGridView.Columns.Clear();
            productsGridView.AutoGenerateColumns = false;

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "الرقم",
                DataPropertyName = "ID",
                Width = 50,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "الاسم",
                DataPropertyName = "Name",
                Width = 150,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "الوصف",
                DataPropertyName = "Description",
                Width = 200,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "السعر",
                DataPropertyName = "Price",
                Width = 100,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "الكمية",
                DataPropertyName = "Quantity",
                Width = 100,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "الأصناف",
                DataPropertyName = "CategoryName",
                Width = 100,
                ReadOnly = true
            });

            productsGridView.EnableHeadersVisualStyles = false;
            productsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            productsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            productsGridView.ColumnHeadersHeight = 40;
            productsGridView.RowTemplate.Height = 35;
            productsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            productsGridView.CellFormatting += ProductsGridView_CellFormatting;
        }

        private void LoadProducts()
        {
            context?.Dispose();
            context = new Context();

            filteredQuery = GetFilteredQuery();

            if (productsGridView.RowTemplate.Height > 0 && productsGridView.Height > 0)
            {
                pageSize = productsGridView.Height / productsGridView.RowTemplate.Height;
            }
            else
            {
                pageSize = 10;
            }
            if (pageSize <= 0) pageSize = 1;

            var totalItems = filteredQuery.Count();
            totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            if (currentPage > totalPages)
                currentPage = totalPages;
            if (currentPage < 1)
                currentPage = 1;

            var products = filteredQuery
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            if (products.Any())
            {
                productsGridView.Visible = true;
                totalProductsLabel.Visible = true;
                filterPanel.Visible = true;
                btnAddProduct.Visible = true;
                btnEditProduct.Visible = true;
                btnDeleteProduct.Visible = true;
                pnlNoProductsMessage.Visible = false;
                paginationPanel.Visible = true;

                productsGridView.DataSource = null;
                productsGridView.DataSource = products;
                productsGridView.Refresh();
                UpdateTotalProductsLabel(totalItems);
                UpdatePaginationControls();
            }
            else
            {
                productsGridView.Visible = false;
                totalProductsLabel.Visible = false;
                filterPanel.Visible = false;
                btnAddProduct.Visible = false;
                btnEditProduct.Visible = false;
                btnDeleteProduct.Visible = false;
                paginationPanel.Visible = false;

                pnlNoProductsMessage.Left = (this.ClientSize.Width - pnlNoProductsMessage.Width) / 2;
                pnlNoProductsMessage.Top = (this.ClientSize.Height - pnlNoProductsMessage.Height) / 2;

                int labelWidth = lblNoProductsText.Width;
                int buttonWidth = btnAddNewProductInline.Width;
                int leftMargin = Math.Max(0, (labelWidth - buttonWidth) / 2);
                btnAddNewProductInline.Margin = new Padding(leftMargin, 10, 0, 3);

                pnlNoProductsMessage.Visible = true;
            }
        }

        private IQueryable<dynamic> GetFilteredQuery()
        {
            var searchTerm = searchTextBox.Text.Trim().ToLower();
            var selectedCategory = categoryComboBox.SelectedItem;
            string minPriceText = txtMinPrice.Text.Trim();
            string maxPriceText = txtMaxPrice.Text.Trim();
            string stockStatusValue = (stockStatusComboBox.SelectedItem as dynamic).Value;

            decimal minPrice = 0;
            decimal maxPrice = decimal.MaxValue;

            if (!string.IsNullOrEmpty(minPriceText) && decimal.TryParse(minPriceText, out decimal parsedMinPrice))
            {
                minPrice = parsedMinPrice;
            }

            if (!string.IsNullOrEmpty(maxPriceText) && decimal.TryParse(maxPriceText, out decimal parsedMaxPrice))
            {
                maxPrice = parsedMaxPrice;
            }

            var query = context.Products.Include(p => p.Category).AsQueryable();

            if (selectedCategory != null)
            {
                int selectedCategoryId = 0;
                dynamic item = selectedCategory;
                if (item.ID != null)
                {
                    selectedCategoryId = (int)item.ID;
                }

                if (selectedCategoryId != 0)
                {
                    query = query.Where(p => p.CategoryId == selectedCategoryId);
                }
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.Name.ToLower().Contains(searchTerm) ||
                                       p.Description.ToLower().Contains(searchTerm));
            }

            query = query.Where(p => (decimal)p.Price >= minPrice && (decimal)p.Price <= maxPrice);

            if (stockStatusValue == "InStock")
            {
                query = query.Where(p => p.Quantity > 0);
            }
            else if (stockStatusValue == "OutOfStock")
            {
                query = query.Where(p => p.Quantity <= 0);
            }

            return query.Select(p => new
            {
                p.ID,
                p.Name,
                p.Description,
                p.Price,
                p.Quantity,
                CategoryName = p.Category.Name
            });
        }

        private void UpdatePaginationControls()
        {
            lblPageInfo.Text = $"صفحة {currentPage} من {totalPages}";
            btnFirst.Enabled = currentPage > 1;
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }

        private void LoadCategories()
        {
            var categories = context.Categories.ToList();
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.Add(new { ID = 0, Name = "جميع الأصناف" });
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "ID";

            foreach (var category in categories)
            {
                categoryComboBox.Items.Add(category);
            }

            categoryComboBox.SelectedIndex = 0;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void PriceRange_TextChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void StockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void FilterProducts()
        {
            var searchTerm = searchTextBox.Text.Trim().ToLower();
            var selectedCategory = categoryComboBox.SelectedItem;
            string minPriceText = txtMinPrice.Text.Trim();
            string maxPriceText = txtMaxPrice.Text.Trim();
            string stockStatusValue = (stockStatusComboBox.SelectedItem as dynamic).Value;

            decimal minPrice = 0;
            decimal maxPrice = decimal.MaxValue;

            if (!string.IsNullOrEmpty(minPriceText) && decimal.TryParse(minPriceText, out decimal parsedMinPrice))
            {
                minPrice = parsedMinPrice;
            }

            if (!string.IsNullOrEmpty(maxPriceText) && decimal.TryParse(maxPriceText, out decimal parsedMaxPrice))
            {
                maxPrice = parsedMaxPrice;
            }

            var query = context.Products.Include(p => p.Category).AsQueryable();

            if (selectedCategory != null)
            {
                int selectedCategoryId = 0;
                dynamic item = selectedCategory;
                if (item.ID != null)
                {
                    selectedCategoryId = (int)item.ID;
                }

                if (selectedCategoryId != 0)
                {
                    query = query.Where(p => p.CategoryId == selectedCategoryId);
                }
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.Name.ToLower().Contains(searchTerm) ||
                                       p.Description.ToLower().Contains(searchTerm));
            }

            query = query.Where(p => (decimal)p.Price >= minPrice && (decimal)p.Price <= maxPrice);

            if (stockStatusValue == "InStock")
            {
                query = query.Where(p => p.Quantity > 0);
            }
            else if (stockStatusValue == "OutOfStock")
            {
                query = query.Where(p => p.Quantity <= 0);
            }

            var filteredProducts = query
                 .Select(p => new
                 {
                     p.ID,
                     p.Name,
                     p.Description,
                     p.Price,
                     p.Quantity,
                     CategoryName = p.Category.Name
                 })
                .ToList();

            productsGridView.DataSource = filteredProducts;
            UpdateTotalProductsLabel(filteredProducts.Count);
        }

        private void UpdateTotalProductsLabel(int count)
        {
            totalProductsLabel.Text = $"إجمالي المنتجات: {count}";
        }

        private void ProductsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (productsGridView.Columns[e.ColumnIndex].DataPropertyName == "Quantity" && e.RowIndex >= 0)
            {
                var product = productsGridView.Rows[e.RowIndex].DataBoundItem;
                if (product != null)
                {
                    var quantityProperty = product.GetType().GetProperty("Quantity");
                    if (quantityProperty != null)
                    {
                        int quantity = (int)quantityProperty.GetValue(product);

                        if (quantity > 0)
                        {
                            e.Value = $"متوفر ({quantity})";
                            e.CellStyle.ForeColor = Color.Green;
                        }
                        else
                        {
                            e.Value = "غير متوفر";
                            e.CellStyle.ForeColor = Color.Red;
                        }
                        e.FormattingApplied = true;
                    }
                }
            }
            else if (productsGridView.Columns[e.ColumnIndex].DataPropertyName == "CategoryName" && e.RowIndex >= 0)
            {
                var product = productsGridView.Rows[e.RowIndex].DataBoundItem;
                if (product != null)
                {
                    var categoryNameProperty = product.GetType().GetProperty("CategoryName");
                    if (categoryNameProperty != null)
                    {
                        e.Value = categoryNameProperty.GetValue(product);
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void lblPriceRange_Click(object sender, EventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CenterPaginationPanel();
        }

        private void CenterPaginationPanel()
        {
            int x = (this.ClientSize.Width - paginationPanel.Width) / 2;
            paginationPanel.Location = new Point(x, paginationPanel.Location.Y);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            btnAddProduct.Enabled = false;
            try
            {
                using (var optionsForm = new Form())
                {
                    optionsForm.Text = "إضافة منتج";
                    optionsForm.ControlBox = true;
                    optionsForm.Size = new Size(300, 250);
                    optionsForm.StartPosition = FormStartPosition.CenterParent;
                    optionsForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    optionsForm.MaximizeBox = false;
                    optionsForm.MinimizeBox = false;
                    optionsForm.RightToLeft = RightToLeft.Yes;
                    optionsForm.BackColor = SystemColors.GradientInactiveCaption;

                    var btnSingleProduct = new Button
                    {
                        Text = "إضافة منتج واحد",
                        Size = new Size(200, 50),
                        Location = new Point((optionsForm.ClientSize.Width - 200) / 2, 60),
                        DialogResult = DialogResult.Yes,
                        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                        ForeColor = Color.DarkBlue,
                        BackColor = Color.LightBlue,
                        FlatStyle = FlatStyle.Flat,
                        UseVisualStyleBackColor = true
                    };
                    btnSingleProduct.FlatAppearance.BorderSize = 0;

                    var btnMultipleProducts = new Button
                    {
                        Text = "إضافة عدة منتجات",
                        Size = new Size(200, 50),
                        Location = new Point((optionsForm.ClientSize.Width - 200) / 2, 140),
                        DialogResult = DialogResult.No,
                        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                        ForeColor = Color.Green,
                        UseVisualStyleBackColor = true
                    };

                    optionsForm.Controls.Add(btnSingleProduct);
                    optionsForm.Controls.Add(btnMultipleProducts);

                    var result = optionsForm.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        var detailsForm = new ProductDetailsForm();
                        if (detailsForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadProducts();
                        }
                        detailsForm.Dispose();
                    }
                    else if (result == DialogResult.No)
                    {
                        var multiProductForm = new MultiProductForm();
                        if (multiProductForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadProducts();
                        }
                        multiProductForm.Dispose();
                    }
                }
            }
            finally
            {
                btnAddProduct.Enabled = true;
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            btnEditProduct.Enabled = false;
            try
            {
                if (productsGridView.SelectedRows.Count > 0)
                {
                    var selectedRow = productsGridView.SelectedRows[0];
                    var productID = (int)selectedRow.Cells["ID"].Value;

                    var detailsForm = new ProductDetailsForm(productID);
                    if (detailsForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadProducts();
                    }
                    detailsForm.Dispose();
                }
                else
                {
                    MessageBox.Show("Please select a product to edit.", "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                btnEditProduct.Enabled = true;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            btnDeleteProduct.Enabled = false;
            try
            {
                if (productsGridView.SelectedRows.Count > 0)
                {
                    var selectedRow = productsGridView.SelectedRows[0];
                    var productID = (int)selectedRow.Cells["ID"].Value;

                    var productToDelete = context.Products.Find(productID);

                    if (productToDelete != null)
                    {
                        using (var customMessageBox = new CustomMessageBoxForm("هل أنت متأكد أنك تريد حذف هذا المنتج؟"))
                        {
                            var confirmResult = customMessageBox.ShowDialog();
                            if (confirmResult == DialogResult.Yes)
                            {
                                context.Products.Remove(productToDelete);
                                context.SaveChanges();
                                LoadProducts();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("يرجى اختيار منتج للحذف.", "اختيار منتج", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
            }
            finally
            {
                btnDeleteProduct.Enabled = true;
            }
        }

        private void btnAddNewProductInline_Click(object sender, EventArgs e)
        {
            btnAddProduct_Click(sender, e);
        }

        private void SetButtonHoverEffects(Button button)
        {
            Color originalBackColor = button.BackColor;
            Color hoverColor = Color.FromArgb(0, 120, 215);

            button.MouseEnter += (sender, e) =>
            {
                button.BackColor = hoverColor;
            };

            button.MouseLeave += (sender, e) =>
            {
                button.BackColor = originalBackColor;
            };
        }
    }
} 