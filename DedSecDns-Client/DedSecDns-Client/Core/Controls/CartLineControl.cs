using DedSecDns_Client.Services;
using System;
using System.Windows.Forms;

namespace DedSecDns_Client.Core.Controls
{
    public partial class CartLineControl : UserControl
    {
        public new string ProductName
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public string ProductPrice
        {
            get { return priceLbl.Text; }
            set { priceLbl.Text = value; }
        }

        public CartLineControl()
        {
            InitializeComponent();
        }
        public event EventHandler OnProductRemoved;
        private void removeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = (int)Tag;
            Cart.RemoveProduct(id);
            OnProductRemoved?.Invoke(id, EventArgs.Empty);
        }
    }
}