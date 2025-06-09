using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Stationery_Store.Entities;
using System.Drawing.Printing;

namespace Stationery_Store.Forms
{
    public partial class Report : Form
    {
        Context context = new Context();
        private List<dynamic> filteredOrders;

        public Report()
        {
            InitializeComponent();
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker2.Value.Date;
            DateTime toDate = dateTimePicker1.Value.Date;

            filteredOrders = context.Orders
                .Where(o => o.Date.Date >= fromDate && o.Date.Date <= toDate)
                .Select(o => new
                {
                    OrderID = o.ID,
                    Date = o.Date,
                    Time = o.Date.ToString("HH:mm"),
                    TotalAmount = o.TotalAmount,
                    TotalPrice = o.TotalPrice,
                    ProductName = o.OrderItems.Select(oi => oi.ProductName).FirstOrDefault() ?? "لا يوجد منتج"
                })
                .ToList<dynamic>();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderID",
                HeaderText = "رقم الطلب",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "تاريخ الطلب",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Time",
                HeaderText = "وقت الطلب",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "الكمية الإجمالية",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "الإجمالي",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "اسم المنتج",
                Width = 150
            });

            dataGridView1.DataSource = filteredOrders;

            int totalAmount = filteredOrders.Sum(o => (int)o.TotalAmount);
            double totalRevenue = filteredOrders.Sum(o => (double)o.TotalPrice);

            label4.Text = $"{totalAmount}";
            label6.Text = $"{totalRevenue:C}";

            MessageBox.Show($"تم تحميل {filteredOrders.Count} طلب.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument1;
            preview.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (filteredOrders == null || filteredOrders.Count == 0)
            {
                e.Graphics.DrawString("لا توجد بيانات لعرضها", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, 100);
                return;
            }

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font cellFont = new Font("Arial", 10);
            float lineHeight = cellFont.GetHeight(e.Graphics) + 6;
            float xRight = e.MarginBounds.Right - 50;
            float y = e.MarginBounds.Top;

            StringFormat formatRight = new StringFormat();
            formatRight.Alignment = StringAlignment.Far;

            e.Graphics.DrawString("تقرير الطلبات", titleFont, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, lineHeight), formatRight);
            y += 40;

            // العناوين
            e.Graphics.DrawString("رقم الطلب", headerFont, Brushes.Black, xRight - 0, y, formatRight);
            e.Graphics.DrawString("تاريخ الطلب", headerFont, Brushes.Black, xRight - 100, y, formatRight);
            e.Graphics.DrawString("وقت الطلب", headerFont, Brushes.Black, xRight - 200, y, formatRight);
            e.Graphics.DrawString("الكمية", headerFont, Brushes.Black, xRight - 300, y, formatRight);
            e.Graphics.DrawString("الإجمالي", headerFont, Brushes.Black, xRight - 400, y, formatRight);
            y += lineHeight;

            foreach (var order in filteredOrders)
            {
                e.Graphics.DrawString(order.OrderID.ToString(), cellFont, Brushes.Black, xRight - 0, y, formatRight);
                e.Graphics.DrawString(((DateTime)order.Date).ToShortDateString(), cellFont, Brushes.Black, xRight - 100, y, formatRight);
                e.Graphics.DrawString(order.Time.ToString(), cellFont, Brushes.Black, xRight - 200, y, formatRight);
                e.Graphics.DrawString(order.TotalAmount.ToString(), cellFont, Brushes.Black, xRight - 300, y, formatRight);
                e.Graphics.DrawString(((double)order.TotalPrice).ToString("C"), cellFont, Brushes.Black, xRight - 400, y, formatRight);
                y += lineHeight;
            }

            y += 20;
            int totalAmount = filteredOrders.Sum(o => (int)o.TotalAmount);
            double totalPrice = filteredOrders.Sum(o => (double)o.TotalPrice);

            e.Graphics.DrawString($"إجمالي الكمية: {totalAmount}", headerFont, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, lineHeight), formatRight);
            y += lineHeight;
            e.Graphics.DrawString($"إجمالي السعر: {totalPrice:C}", headerFont, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, lineHeight), formatRight);
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void ReportDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
    }
}
