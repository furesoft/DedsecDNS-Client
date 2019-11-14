using DedSecDns_Client.Core.MVC;
using System;
using System.Windows.Forms;

namespace DedSecDns_Client.Views
{
    public partial class ForgotPasswordView : Form, IView
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

        public ForgotPasswordView()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            AuthService.ResetPassword(usernameTb.Text);
        }
    }
}