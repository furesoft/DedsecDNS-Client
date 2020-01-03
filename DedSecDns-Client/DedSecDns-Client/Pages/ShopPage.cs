using DedSecDns_Client.Core;
using DedSecDns_Client.Core.Controls;
using DedSecDns_Client.Core.Popup;
using DedSecDns_Client.Models;
using DedSecDns_Client.Properties;
using DedSecDns_Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private void cartBtn_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new CartPage());
        }

        private void FillProductLine(int start)
        {
            var lineView = new FlowLayoutPanel();
            lineView.FlowDirection = FlowDirection.LeftToRight;
            lineView.AutoScroll = true;
            lineView.AutoSize = true;
            lineView.WrapContents = false;

            var products = ProductRepository.GetProducts(start);

            FillProductsToView(products, lineView);

            productListView.Controls.Add(lineView);
        }

        private void FillProductsToView(IEnumerable<Product> products, FlowLayoutPanel view)
        {
            foreach (var p in products)
            {
                var ui = new ProductControl();
                ui.ProductName = p.Name;
                ui.ProductPrice = p.Price.ToString();
                ui.ProductID = p.ID;
                ui.Image = p.Image;

                view.Controls.Add(ui);
            }
        }

        private void ShopPage_Load(object sender, System.EventArgs e)
        {
            Cart.Init(this);
            ProductRepository.Init();

            FillProductLine(0);
            FillProductLine(6);
        }
    }
}