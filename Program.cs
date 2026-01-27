using GreenLife_Organic_Store.Forms.Admin;
using GreenLife_Organic_Store.Forms.Customer;
using GreenLife_Organic_Store.Forms.Modals;

namespace GreenLife_Organic_Store
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
            //Application.Run(new frmCustomerLogin());
            //Application.Run(new frmCustomerDashboardForm(2));
            //Application.Run(new frmSearchForm(3));
            Application.Run(new frmAdminDashboardForm(1));

        }
    }
}