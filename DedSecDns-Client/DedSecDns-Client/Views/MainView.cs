using DedSecDns_Client.Controllers;
using DedSecDns_Client.Core;
using DedSecDns_Client.Core.MVC;
using DedSecDns_Client.Pages;
using System.Windows.Forms;

namespace DedSecDns_Client.Views
{
    public partial class MainView : Form, IView
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

        public MainView()
        {
            InitializeComponent();
        }

        private void domainMngBtn_Click(object sender, System.EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new ManageDomainsPage());
        }

        private void logoutBtn_Click(object sender, System.EventArgs e)
        {
            Session.Clear();
            AppManager.Instance.Load<LoginViewController>();
        }

        private void tldManageBtn_Click(object sender, System.EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new ManageTldPage());
        }

        private void xuiNavigationBar1_Click(object sender, System.EventArgs e)
        {
        }

        private void xuiNavigationBar1_LeftItemClick(object sender, System.EventArgs e)
        {
        }

        private void xuiNavigationBar1_RightItemClick(object sender, System.EventArgs e)
        {
        }
    }
}