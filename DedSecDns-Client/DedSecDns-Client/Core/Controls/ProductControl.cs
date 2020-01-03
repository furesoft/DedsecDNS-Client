using System.Drawing;
using System.Windows.Forms;

namespace DedSecDns_Client.Core.Controls
{
    public partial class ProductControl : UserControl
    {
        public Image Image
        {
            get { return imagePb.Image; }
            set { imagePb.Image = value; }
        }

        public int ProductID
        {
            get { return (int)addToCartButton1.Tag; }
            set { addToCartButton1.Tag = value; }
        }

        public new string ProductName
        {
            get { return productNameLbl.Text; }
            set { productNameLbl.Text = value; }
        }

        public string ProductPrice
        {
            get { return priceLbl.Text; }
            set { priceLbl.Text = "Preis: " + value; }
        }

        public ProductControl()
        {
            InitializeComponent();
        }
    }
}