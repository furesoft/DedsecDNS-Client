using DedSecDns_Client.Views;
using System.Windows.Forms;

namespace DedSecDns_Client.Services
{
    public class NavigationService
    {
        public static void Init(MainView main)
        {
            _main = main;
        }

        public static void Navigate(UserControl c)
        {
            _main.Navigate(c);
        }

        private static MainView _main;
    }
}