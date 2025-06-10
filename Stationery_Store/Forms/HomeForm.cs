using Microsoft.Data.Sqlite;
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

            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // يمنع تغيير الحجم
            this.MaximizeBox = false;  // يخفي زر التكبير
            this.MinimizeBox = true;   // يمكن تغييره حسب الحاجة
            this.SizeGripStyle = SizeGripStyle.Hide;

            this.WindowState = FormWindowState.Maximized;//الهورم يتملى الشاشة


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
                //BackupBtn.Visible = false;

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
                sidebar.Width -= 27;
                if (sidebar.Width <= 66)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 27;
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
                categoryForm.Show();
                // Force resize after showing
                categoryForm.WindowState = FormWindowState.Normal;
                categoryForm.WindowState = FormWindowState.Maximized;
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
                sellForm.Show();
                sellForm.WindowState = FormWindowState.Normal;
                sellForm.WindowState = FormWindowState.Maximized;
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
                productsForm.FormBorderStyle = FormBorderStyle.None;
                productsForm.Show();
                productsForm.WindowState = FormWindowState.Normal;
                productsForm.WindowState = FormWindowState.Maximized;
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
                reportForm.Show();
                reportForm.WindowState = FormWindowState.Normal;
                reportForm.WindowState = FormWindowState.Maximized;
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
                usersForm.Show();
                usersForm.WindowState = FormWindowState.Normal;
                usersForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                usersForm.Activate();
            }

            lastActiveChild = usersForm;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        private void BackupSqliteDatabase(string sourcePath, string destinationPath)
        {
            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath, true); // true = overwrite if exists
            }
            else
            {
                MessageBox.Show("❌ قاعدة البيانات الأصلية غير موجودة!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            // Get the path of the executable (base directory)
            string projectBasePath = AppDomain.CurrentDomain.BaseDirectory;

            // Define the backup folder path inside the project directory
            string backupFolder = Path.Combine(projectBasePath, "backup");

            // Create the backup folder if it doesn't exist
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }

            // Define the path of the source database
            string dbPath = Path.Combine(projectBasePath, "Data", "appdata.db");

            // Show Save File Dialog with default path set to the backup folder
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = backupFolder,
                Filter = "SQLite Database (*.sqlite)|*.sqlite|All Files (*.*)|*.*",
                FileName = "BackupDatabase.sqlite"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupFilePath = saveFileDialog.FileName;
                BackupSqliteDatabase(dbPath, backupFilePath);
                MessageBox.Show("✅ تم إنشاء نسخة احتياطية بنجاح!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}

