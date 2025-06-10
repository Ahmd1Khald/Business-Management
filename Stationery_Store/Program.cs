using Microsoft.EntityFrameworkCore; // علشان تقدر تستخدم Migrate
using Stationery_Store.Entities; // علشان تقدر تستدعي الـ Context
using Stationery_Store.Forms;
using System;
using System.Windows.Forms;

namespace Stationery_Store
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // إنشاء قاعدة البيانات وتطبيق المايجريشنز إن وُجدت
            using (var context = new Context())
            {
                context.Database.Migrate(); // هنا بيتأكد إن الداتا بيز متحدثة وجاهزة
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new HomeForm(loginForm.LoggedInUserRole));
                }

                // Forms:
                // CategoryForm
                // SellForm
                // HomeForm(loginForm.LoggedInUserRole)
                // LoginForm
                // ProductsForm
                // Report
                // UsersForm
            }
        }
    }
}
