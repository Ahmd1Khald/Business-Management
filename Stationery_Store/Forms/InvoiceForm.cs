using Stationery_Store.Entities;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class InvoiceForm : Form
    {
        private Order currentOrder;

        public InvoiceForm(Order order)
        {
            InitializeComponent();
            currentOrder = order;
            LoadInvoiceData();
        }

        private void LoadInvoiceData()
        {
            labelDate.Text = $"التاريخ: {currentOrder.Date}";
            labelTotalPrice.Text = $"الإجمالي: {currentOrder.TotalPrice} جنيه";
            labelTotalQuantity.Text = $"الكمية: {currentOrder.TotalAmount}";

            invoiceGridView.Columns.Add("ProductName", "اسم المنتج");
            invoiceGridView.Columns.Add("Quantity", "الكمية");
            invoiceGridView.Columns.Add("Price", "السعر");

            foreach (var item in currentOrder.OrderItems)
            {
                invoiceGridView.Rows.Add(item.Product.Name, item.Quantity, item.UnitPrice);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 100;
            Font font = new Font("Arial", 12);
            e.Graphics.DrawString("فاتورة بيع", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 300, y);
            y += 40;

            e.Graphics.DrawString($"التاريخ: {currentOrder.Date}", font, Brushes.Black, 50, y); y += 30;
            e.Graphics.DrawString("------------------------------------------------", font, Brushes.Black, 50, y); y += 30;

            foreach (var item in currentOrder.OrderItems)
            {
                e.Graphics.DrawString($"{item.Product.Name} × {item.Quantity} = {item.UnitPrice * item.Quantity} جنيه", font, Brushes.Black, 50, y);
                y += 30;
            }

            y += 20;
            e.Graphics.DrawString("------------------------------------------------", font, Brushes.Black, 50, y); y += 30;
            e.Graphics.DrawString($"الإجمالي: {currentOrder.TotalPrice} جنيه", font, Brushes.Black, 50, y);
        }
    }
}
