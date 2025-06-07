using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stationery_Store.Entities;
using System.Drawing.Printing;


namespace Stationery_Store.Forms
{
    public partial class Report : Form
    {
        Context context = new Context();
        private List<Order> orders = new List<Order>();


        public Report()
        {
            InitializeComponent();
            orders.Add(new Order { ID = 1, Date = new DateTime(2025, 6, 1), TotalAmount = 5, TotalPrice = 100 });
            orders.Add(new Order { ID = 2, Date = new DateTime(2025, 6, 5), TotalAmount = 3, TotalPrice = 60 });
            orders.Add(new Order { ID = 3, Date = new DateTime(2025, 6, 8), TotalAmount = 5, TotalPrice = 100 });
            orders.Add(new Order { ID = 4, Date = new DateTime(2025, 6, 10), TotalAmount = 3, TotalPrice = 60 });
            orders.Add(new Order { ID = 5, Date = new DateTime(2025, 6, 11), TotalAmount = 5, TotalPrice = 100 });
            orders.Add(new Order { ID = 6, Date = new DateTime(2025, 6, 12), TotalAmount = 3, TotalPrice = 60 });
            orders.Add(new Order { ID = 7, Date = new DateTime(2025, 6, 22), TotalAmount = 5, TotalPrice = 100 });
            orders.Add(new Order { ID = 7, Date = new DateTime(2025, 6, 30), TotalAmount = 3, TotalPrice = 60 });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument1;
            preview.ShowDialog();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void ReportDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker2.Value.Date;
            DateTime toDate = dateTimePicker1.Value.Date;

            var filteredOrders = orders
                .Where(o => o.Date.Date >= fromDate && o.Date.Date <= toDate)
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredOrders;

            int totalAmount = filteredOrders.Sum(o => o.TotalAmount);
            double totalRevenue = filteredOrders.Sum(o => o.TotalPrice);

            label4.Text = $"{totalAmount}";
            label6.Text = $"{totalRevenue:C}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            float lineHeight = font.GetHeight(e.Graphics) + 4;
            float x = 50;
            float y = 50;

            e.Graphics.DrawString("Order Report", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x, y);
            y += 40;

            foreach (Order order in dataGridView1.DataSource as List<Order>)
            {
                string line = $"ID: {order.ID}   Date: {order.Date.ToShortDateString()}   Qty: {order.TotalAmount}   Price: {order.TotalPrice:C}";
                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += lineHeight;
            }

            y += 20;
            int totalAmount = (dataGridView1.DataSource as List<Order>).Sum(o => o.TotalAmount);
            double totalPrice = (dataGridView1.DataSource as List<Order>).Sum(o => o.TotalPrice);

            e.Graphics.DrawString($"Total Quantity: {totalAmount}", font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString($"Total Revenue: {totalPrice:C}", font, Brushes.Black, x, y);
        }
    }
}
