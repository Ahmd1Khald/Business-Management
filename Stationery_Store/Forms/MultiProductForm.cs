using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Stationery_Store.Entities;

namespace Stationery_Store.Forms
{
    public partial class MultiProductForm : Form
    {
        private Context context = new Context();
        private DataTable productsTable;

        public MultiProductForm()
        {
            InitializeComponent();
            InitializeDataTable();
            SetupDataGridView();
            LoadCategories();
        }

        private void InitializeDataTable()
        {
            productsTable = new DataTable();
            productsTable.Columns.Add("Name", typeof(string));
            productsTable.Columns.Add("Description", typeof(string));
            productsTable.Columns.Add("Price", typeof(double));
            productsTable.Columns.Add("Quantity", typeof(int));
            productsTable.Columns.Add("CategoryId", typeof(int));
        }

        private void SetupDataGridView()
        {
            productsDataGridView.DataSource = productsTable;

            productsDataGridView.Columns["Name"].HeaderText = "الاسم";
            productsDataGridView.Columns["Description"].HeaderText = "الوصف";
            productsDataGridView.Columns["Price"].HeaderText = "السعر";
            productsDataGridView.Columns["Quantity"].HeaderText = "الكمية";

            var categoryColumn = new DataGridViewComboBoxColumn
            {
                Name = "Category", // Renamed to be clearer, HeaderText will be "أصناف"
                HeaderText = "الأصناف",
                DataPropertyName = "CategoryId",
                DisplayMember = "Name",
                ValueMember = "ID",
                DataSource = context.Categories.ToList(),
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton // Ensure it looks like a dropdown
            };
            productsDataGridView.Columns.Add(categoryColumn);

            productsDataGridView.Columns["CategoryId"].Visible = false;

            productsDataGridView.EnableHeadersVisualStyles = false;
            productsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            productsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            productsDataGridView.ColumnHeadersHeight = 40;
            productsDataGridView.RowTemplate.Height = 35;
            productsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            productsDataGridView.DefaultValuesNeeded += ProductsDataGridView_DefaultValuesNeeded;

            productsDataGridView.CellValidated += ProductsDataGridView_CellValidated;
        }

        private void LoadCategories()
        {
            var categories = context.Categories.ToList();
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "ID";
            categoryComboBox.DataSource = categories;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataRow newRow = productsTable.NewRow();

            var selectedCategory = categoryComboBox.SelectedItem as Category;

            if (selectedCategory != null)
            {
                newRow["CategoryId"] = selectedCategory.ID;
            }
            else
            {
                newRow["CategoryId"] = DBNull.Value; // Or some other indicator
            }

            productsTable.Rows.Add(newRow);

            if (selectedCategory != null)
            {
                int categoryColumnIndex = productsDataGridView.Columns["Category"].Index;

                DataGridViewRow dgvRow = productsDataGridView.Rows[productsDataGridView.Rows.Count - 1];

                dgvRow.Cells[categoryColumnIndex].Value = selectedCategory.ID;
            }
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            productsDataGridView.EndEdit();

            if (productsDataGridView.SelectedRows.Count > 0)
            {
                List<DataRow> rowsToRemove = new List<DataRow>();

                foreach (DataGridViewRow row in productsDataGridView.SelectedRows)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        rowsToRemove.Add(drv.Row);
                    }
                }

                foreach (DataRow row in rowsToRemove)
                {
                    productsTable.Rows.Remove(row);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in productsTable.Rows)
                {
                    if (string.IsNullOrWhiteSpace(row["Name"].ToString()))
                        continue;

                    var product = new Product
                    {
                        Name = row["Name"].ToString(),
                        Description = row["Description"].ToString(),
                        Price = Convert.ToDouble(row["Price"]),
                        Quantity = Convert.ToInt32(row["Quantity"]),
                        CategoryId = Convert.ToInt32(row["CategoryId"])
                    };

                    context.Products.Add(product);
                }

                context.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ المنتجات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ProductsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var selectedCategory = categoryComboBox.SelectedItem as Category;

            if (selectedCategory != null)
            {
                e.Row.Cells["Category"].Value = selectedCategory.ID;
            }
        }

        private void ProductsDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (productsDataGridView.Columns[e.ColumnIndex].Name == "Category")
            {
                productsDataGridView.EndEdit();
            }
        }
    }
} 
 