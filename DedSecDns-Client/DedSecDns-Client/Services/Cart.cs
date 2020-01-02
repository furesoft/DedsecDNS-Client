using DedSecDns_Client.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSecDns_Client.Services
{
    public static class Cart
    {
        public static void AddProduct(int id)
        {
            ShowInfo();
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
    }
}