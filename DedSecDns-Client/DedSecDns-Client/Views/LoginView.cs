using DedSecDns_Client.Controllers;
using DedSecDns_Client.Core.MVC;
using System;
using System.Windows.Forms;

namespace DedSecDns_Client.Views
{
    public partial class LoginView : Form, IView
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

        public LoginView()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, System.EventArgs e)
        {
            if (AuthService.Authenticate(usernameTb.Text, passwordTb.Text))
            {
                AppManager.Instance.Load<MainViewController>();
            }
        }

        private void passwordTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, EventArgs.Empty);
            }
        }
    }
}