using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class ProductsForm : Form
    {
        private void ConfigureProductGrid()
        {
            productsGridView.Columns.Clear();

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الرقم",
                DataPropertyName = "ID",
                Width = 50,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الاسم",
                DataPropertyName = "Name",
                Width = 150,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الوصف",
                DataPropertyName = "Description",
                Width = 200,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "السعر",
                DataPropertyName = "Price",
                Width = 100,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الكمية",
                DataPropertyName = "Quantity",
                Width = 100,
                ReadOnly = true
            });

            // Hide unwanted columns if they exist
            if (productsGridView.Columns.Contains("OrderItems"))
            {
                productsGridView.Columns["OrderItems"].Visible = false;
            }
            if (productsGridView.Columns.Contains("CategoryId"))
            {
                productsGridView.Columns["CategoryId"].Visible = false;
            }

            // Configure grid appearance
            productsGridView.EnableHeadersVisualStyles = false;
            productsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            productsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            productsGridView.ColumnHeadersHeight = 40;
            productsGridView.RowTemplate.Height = 35;
            productsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }
    }
} 