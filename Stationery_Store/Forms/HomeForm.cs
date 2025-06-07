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

        
        private Form lastActiveChild;


        public HomeForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

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
                //sellForm.MdiParent = this;
                sellForm.FormBorderStyle = FormBorderStyle.None;  // Remove borders
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
    }
}
