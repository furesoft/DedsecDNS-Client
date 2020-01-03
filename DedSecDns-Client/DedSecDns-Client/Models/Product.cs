using System.Drawing;

namespace DedSecDns_Client.Models
{
    public class Product
    {
        public int Category { get; set; }
        public int ID { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}