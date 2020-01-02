using DedSecDns_Client.Controllers;
using DedSecDns_Client.Core;
using DedSecDns_Client.Core.Controls;
using DedSecDns_Client.Core.MVC;
using DedSecDns_Client.Core.Popup;
using DedSecDns_Client.Pages;
using DedSecDns_Client.Services;
using System;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.WinForms;

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

        internal void Navigate(UserControl page)
        {
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);

            this.xuiObjectAnimator1.StandardAnimate(page, XanderUI.XUIObjectAnimator.StandardAnimation.SlideUp, 35000);
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

        private void MainView_Load(object sender, EventArgs e)
        {
            NavigationService.Init(this);

            ColorScheme.Apply(ColorScheme.Default, panel1);

            CommandRepository.Collect();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowSearchBar();
        }

        private void ShowSearchBar()
        {
            new Popup(new SearchBarControl()).Show(searchbarPanel);
        }

        private void tldManageBtn_Click(object sender, System.EventArgs e)
        {
            Navigate(new ManageTldPage());
        }

        private void welcomePage1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.S)
            {
                ShowSearchBar();
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Navigate(new ShopPage());
        }
    }
}