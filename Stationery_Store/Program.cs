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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());
            //CategoryForm
            //SellForm
            //HomeForm
            //LoginForm
            //ProductsForm
            //Report
        }
    }
}