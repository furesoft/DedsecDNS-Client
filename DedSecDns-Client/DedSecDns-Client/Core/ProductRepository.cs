﻿using DedSecDns_Client.Models;
using DedSecDns_Client.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DedSecDns_Client.Core
{
    public static class ProductRepository
    {
        public static void AddCategory(string name)
        {
            _categories.Add(name);
        }

        public static IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public static IEnumerable<Product> GetByCategory(int cat)
        {
            foreach (var p in _products)
            {
                if (p.Category == cat)
                {
                    yield return p;
                }
            }
        }

        public static Product GetByID(int id)
        {
            foreach (var p in _products)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }

            return null;
        }

        public static string[] GetCategorys()
        {
            return _categories.ToArray();
        }

        public static IEnumerable<Product> GetProducts(int start = 0, int count = 5)
        {
            return _products.Skip(start).Take(count);
        }

        public static void Init()
        {
            _products = GetRandomProducts().ToList();
        }

        private static readonly List<string> _categories = new List<string>();
        private static List<Product> _products = new List<Product>();

        private static IEnumerable<Product> GetRandomProducts()
        {
            var names = new[] { "Schwamm", "Apfel", "Brot", "Gold", "Banane", "Hut", "Stuhl", "Jacke" };
            var prices = new[] { 0.99m, 1.89m, 3.99m, 45.31m, 99.00m };
            int currentID = 0;
            var rndm = new Random();

            for (int i = 0; i < 15; i++)
            {
                var p = new Product();
                p.ID = currentID++;
                p.Name = names[rndm.Next(0, names.Length - 1)];
                p.Price = prices[rndm.Next(0, prices.Length - 1)];
                p.Image = Resources.ok_mark;
                p.Category = rndm.Next(0, 1);

                yield return p;
            }
        }
    }
}