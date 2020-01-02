using DedSecDns_Client.Pages;
using System.Collections.Generic;

namespace DedSecDns_Client.Services
{
    public static class Cart
    {
        public static void AddProduct(object product)
        {
            _products.Add(product);

            ShowInfo();
        }

        public static List<object> GetProducts()
        {
            return _products;
        }

        public static void Init(ShopPage page)
        {
            _page = page;
        }

        public static void ShowInfo()
        {
            _page.ShowCartInfo();
        }

        private static ShopPage _page;
        private static List<object> _products = new List<object>();
    }
}