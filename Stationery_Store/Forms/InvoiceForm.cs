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
            //labelDate.Text = $"التاريخ: {currentOrder.Date}";
            //labelTotalPrice.Text = $"الإجمالي: {currentOrder.TotalPrice} جنيه";
            //labelTotalQuantity.Text = $"الكمية: {currentOrder.TotalAmount}";

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

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int startX = 550; // بداية الطباعة من اليمين (حسب عرض الصفحة)
            int startY = 100;
            int offsetY = 30;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font itemFont = new Font("Arial", 12);

            // إعداد محاذاة النص من اليمين
            StringFormat rightAlign = new StringFormat();
            rightAlign.Alignment = StringAlignment.Far; // محاذاة من اليمين
            rightAlign.LineAlignment = StringAlignment.Center;

            // عنوان الفاتورة
            e.Graphics.DrawString("فاتورة بيع", titleFont, Brushes.Black, startX, startY, rightAlign);
            startY += offsetY + 10;

            // التاريخ
            e.Graphics.DrawString($"التاريخ: {currentOrder.Date}", itemFont, Brushes.Black, startX, startY, rightAlign);
            startY += offsetY;

            // خط فصل
            e.Graphics.DrawLine(Pens.Black, 50, startY, startX, startY);
            startY += 10;

            // رؤوس الأعمدة: اسم المنتج | الكمية | سعر الوحدة | المجموع
            int colProductNameX = startX;
            int colQuantityX = 350;
            int colUnitPriceX = 250;
            int colTotalX = 150;

            e.Graphics.DrawString("اسم المنتج", headerFont, Brushes.Black, colProductNameX, startY, rightAlign);
            e.Graphics.DrawString("الكمية", headerFont, Brushes.Black, colQuantityX, startY, rightAlign);
            e.Graphics.DrawString("سعر الوحدة", headerFont, Brushes.Black, colUnitPriceX, startY, rightAlign);
            e.Graphics.DrawString("الإجمالي", headerFont, Brushes.Black, colTotalX, startY, rightAlign);
            startY += offsetY;

            // خط فصل تحت رؤوس الأعمدة
            e.Graphics.DrawLine(Pens.Black, 50, startY, startX, startY);
            startY += 10;

            // تفاصيل البنود
            foreach (var item in currentOrder.OrderItems)
            {
                double totalPerItem = item.UnitPrice * item.Quantity;

                e.Graphics.DrawString(item.Product.Name, itemFont, Brushes.Black, colProductNameX, startY, rightAlign);
                e.Graphics.DrawString(item.Quantity.ToString(), itemFont, Brushes.Black, colQuantityX, startY, rightAlign);
                e.Graphics.DrawString($"{item.UnitPrice} جنيه", itemFont, Brushes.Black, colUnitPriceX, startY, rightAlign);
                e.Graphics.DrawString($"{totalPerItem} جنيه", itemFont, Brushes.Black, colTotalX, startY, rightAlign);

                startY += offsetY;
            }

            startY += 10;
            e.Graphics.DrawLine(Pens.Black, 50, startY, startX, startY);
            startY += 10;

            // الإجمالي النهائي
            e.Graphics.DrawString($"الإجمالي: {currentOrder.TotalPrice} جنيه", headerFont, Brushes.Black, startX, startY, rightAlign);
        }

    }
}
