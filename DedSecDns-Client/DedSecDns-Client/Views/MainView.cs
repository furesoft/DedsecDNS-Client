using DedSecDns_Client.Core.MVC;
using System.Windows.Forms;

namespace DedSecDns_Client.Views
{
    public partial class MainView : Form, IView
    {
        public Form Form => this;

        public string Title
        {
            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }
        }

        public MainView()
        {
            InitializeComponent();
        }

        private void xuiNavigationBar1_Click(object sender, System.EventArgs e)
        {
        }

        private void xuiNavigationBar1_LeftItemClick(object sender, System.EventArgs e)
        {
        }

        private void xuiNavigationBar1_RightItemClick(object sender, System.EventArgs e)
        {
        }
    }
}