using System;
using System.Data;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class MultiProductForm : Form
    {
        private DataTable productsTable;

        public MultiProductForm()
        {
            InitializeComponent();
            productsTable = new DataTable();
            SetupDataTable();
            SetupDataGridView();
        }

        private void SetupDataTable()
        {
            productsTable.Columns.Add("Price", typeof(double));
            productsTable.Columns.Add("Quantity", typeof(int));
            productsTable.Columns.Add("CategoryId", typeof(int));
        }

        private void SetupDataGridView()
        {
            // ... existing code ...
        }
    }
} 