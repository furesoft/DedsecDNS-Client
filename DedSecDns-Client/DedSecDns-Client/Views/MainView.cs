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
            Navigate(new ManageDomainsPage());

            notificationControl1.Message = "Info: ";
        }

        private void logoutBtn_Click(object sender, System.EventArgs e)
        {
            Session.Clear();
            AppManager.Instance.Load<LoginViewController>();
        }

        private void Navigate(UserControl page)
        {
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);

            this.xuiObjectAnimator1.StandardAnimate(page, XanderUI.XUIObjectAnimator.StandardAnimation.SlideUp, 1000);
        }

        private void tldManageBtn_Click(object sender, System.EventArgs e)
        {
            Navigate(new ManageTldPage());
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