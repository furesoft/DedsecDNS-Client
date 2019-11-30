using DedSecDns_Client.Controllers;
using DedSecDns_Client.Core;
using DedSecDns_Client.Core.MVC;
using nUpdate.Updating;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedSecDns_Client
{
    public partial class SplashView : Form, IView
    {
        public Form Form => this;

        public string Title
        {
            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }
        }

        public SplashView()
        {
            InitializeComponent();
        }

        private async void SplashView_Load(object sender, EventArgs e)
        {
            Hide();
            xuiSplashScreen1.initializeLoader(this);

            Updater.InstallIfAvailable();

            await Task.Delay(1500);

            AppManager.Instance.Load<LoginViewController>();
        }
    }
}