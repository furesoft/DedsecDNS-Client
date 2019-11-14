using DedSecDns_Client.Controllers;
using DedSecDns_Client.Core.MVC;
using System;
using System.Windows.Forms;

namespace DedSecDns_Client
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppManager.Start<SplashController>();
        }
    }
}