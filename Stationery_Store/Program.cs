using Stationery_Store.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new HomeForm(loginForm.LoggedInUserRole));
                }
                //CategoryForm
                //SellForm
                //HomeForm(loginForm.LoggedInUserRole)
                //LoginForm
                //ProductsForm
                //Report
                //UsersForm
            }
        }

    }
}