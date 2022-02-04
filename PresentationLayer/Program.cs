using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginView loginView = new LoginView();
            if (loginView.ShowDialog() == DialogResult.OK)
                Application.Run(new DashboardView());
            else
                Application.Exit();
        }
    }
}
