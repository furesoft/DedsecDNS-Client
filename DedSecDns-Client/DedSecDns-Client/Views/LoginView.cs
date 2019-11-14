﻿using DedSecDns_Client.Controllers;
using DedSecDns_Client.Core.MVC;
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

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppManager.Instance.ShowDialog(new ForgotPasswordController());
        }

        private void loginBtn_Click(object sender, System.EventArgs e)
        {
            AuthService.Authenticate(usernameTb.Text, passwordTb.Text);
        }
    }
}