using DedSecDns_Client.Properties;
using DedSecDns_Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSecDns_Client.Core.Controls
{
    public class AddToCartButton : XanderUI.XUIButton
    {
        public AddToCartButton()
        {
            ButtonText = "Zum Warenkorb hinzufügen";
            ButtonImage = Resources.add_to_the_cart;
            this.ButtonStyle = Style.Material;
            Click += AddToCartButton_Click;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Cart.AddProduct(ProductRepository.GetByID((int)Tag));
            //ToDo: implement addtocart button click: use tag as product id, add product from availableproducts collection
            Cart.ShowInfo();
        }
    }
}