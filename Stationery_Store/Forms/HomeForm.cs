using Stationery_Store.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class HomeForm : Form
    {
        CategoryForm categoryForm;
        SellForm sellForm;
        ProductsForm productsForm;
        Report reportForm;
        UsersForm usersForm;



        private Form lastActiveChild;
        private Role userRole;



        public HomeForm(Role role)
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            this.userRole = role;

            this.Shown += HomeForm_Shown;

        }

        private void HomeForm_Shown(object sender, EventArgs e)
        {
            if (userRole != Role.Admin)
            {
                // إخفاء كل الأزرار ما عدا البيع
                buttonCategories.Visible = false;
                buttonProducts.Visible = false;
                buttonReports.Visible = false;
                buttonUsers.Visible = false;

                // مباشرة عرض شاشة البيع للمستخدم العادي
                buttonSell.PerformClick();
            }
        }

        private void HomeForm_Resize(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.WindowState != FormWindowState.Maximized)
                {
                    child.WindowState = FormWindowState.Maximized;
                }
            }

            lastActiveChild?.Activate();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 66)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 187)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }

            }

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            if (categoryForm == null)
            {
                categoryForm = new CategoryForm();
                categoryForm.FormClosed += categoryForm_FormClosed;
                categoryForm.MdiParent = this;
                categoryForm.FormBorderStyle = FormBorderStyle.None;
                categoryForm.WindowState = FormWindowState.Maximized;
                categoryForm.Show();
            }
            else
            {
                categoryForm.Activate();
            }

            lastActiveChild = categoryForm;
        }

        private void categoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoryForm = null;
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (sellForm == null)
            {
                sellForm = new SellForm();
                sellForm.FormClosed += sellForm_FormClosed;
                sellForm.MdiParent = this;
                sellForm.FormBorderStyle = FormBorderStyle.None;
                sellForm.WindowState = FormWindowState.Maximized;
                sellForm.Show();
            }
            else
            {
                sellForm.Activate();
            }
            lastActiveChild = sellForm;
        }

        private void sellForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sellForm = null;
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            if (productsForm == null)
            {
                productsForm = new ProductsForm();
                productsForm.FormClosed += productsForm_FormClosed;
                productsForm.MdiParent = this;
                productsForm.FormBorderStyle = FormBorderStyle.None;  // Remove borders
                productsForm.WindowState = FormWindowState.Maximized;
                productsForm.Show();
            }
            else
            {
                productsForm.Activate();
            }
            lastActiveChild = productsForm;
        }
        private void productsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            productsForm = null;
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
            {
                reportForm = new Report();
                reportForm.FormClosed += reportForm_FormClosed;
                reportForm.MdiParent = this;
                reportForm.FormBorderStyle = FormBorderStyle.None;  // Remove borders
                reportForm.WindowState = FormWindowState.Maximized;
                reportForm.Show();
            }
            else
            {
                reportForm.Activate();
            }
            lastActiveChild = reportForm;
        }

        private void reportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportForm = null;
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            if (usersForm == null)
            {
                usersForm = new UsersForm();
                usersForm.FormClosed += (s, args) => usersForm = null;
                usersForm.MdiParent = this;
                usersForm.FormBorderStyle = FormBorderStyle.None;
                usersForm.WindowState = FormWindowState.Maximized;
                usersForm.Show();
            }
            else
            {
                usersForm.Activate();
            }

            lastActiveChild = usersForm;
        }
    }
}
