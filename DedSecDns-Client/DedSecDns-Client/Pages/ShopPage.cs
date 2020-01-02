using DedSecDns_Client.Core.Controls;
using DedSecDns_Client.Core.Popup;
using DedSecDns_Client.Services;
using System.Windows.Forms;

namespace DedSecDns_Client.Pages
{
    public partial class ShopPage : UserControl
    {
        public ShopPage()
        {
            InitializeComponent();
        }

        internal void ShowCartInfo()
        {
            var an = new XanderUI.XUIObjectAnimator();
            var p = new Popup(new CartAddedPopup());

            p.AutoClose = true;
            p.Show(cartBtn);

            var timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (_, __) =>
            {
                an.StandardAnimate(p, XanderUI.XUIObjectAnimator.StandardAnimation.Hop, 3500);
                p.Close();
                timer.Stop();
            };
            timer.Start();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Cart.ShowInfo();
        }

        private void cartBtn_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new CartPage());
        }

        private void ShopPage_Load(object sender, System.EventArgs e)
        {
            Cart.Init(this);
        }
    }
}