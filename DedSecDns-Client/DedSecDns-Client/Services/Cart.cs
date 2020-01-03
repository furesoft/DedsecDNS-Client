using DedSecDns_Client.Models;
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

        public static List<Product> GetProducts()
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
        private static List<Product> _products = new List<Product>();
    }
}