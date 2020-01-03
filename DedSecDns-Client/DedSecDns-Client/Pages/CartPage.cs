using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DedSecDns_Client.Services;
using DedSecDns_Client.Core.Controls;

namespace DedSecDns_Client.Pages
{
    public partial class CartPage : UserControl
    {
        public CartPage()
        {
            InitializeComponent();
        }

        private void CartPage_Load(object sender, EventArgs e)
        {
            var cartProducts = Cart.GetProducts();

            //fill products of carts to ui
            for (int i = 0; i < cartProducts.Count; i++)
            {
                Models.Product p = cartProducts[i];

                var wrapperControl = new CartLineControl();
                wrapperControl.Tag = i;
                wrapperControl.ProductPrice = p.Price.ToString("{0} EUR");
                wrapperControl.ProductName = p.Name;
                wrapperControl.OnProductRemoved += (s, ee) =>
                {
                    productlList.Controls.Remove(wrapperControl);
                };

                productlList.Controls.Add(wrapperControl);
            }
        }
    }
}