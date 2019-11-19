using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.DataStructures.StringSearch;

namespace DedSecDns_Client.Core.Controls
{
    public partial class SearchBarControl : UserControl
    {
        public SearchBarControl()
        {
            InitializeComponent();
        }

        private void OpenSearchResults()
        {
            var trie = new Trie<string>();
            trie.Add("domain", "Domain hinzufügen");
            trie.Add("update", "Update suchen");

            var result = trie.Retrieve(waterMarkTextBox1.Text);
            var items = new AutoCompleteStringCollection();

            foreach (var item in result)
            {
                items.Add(item);
            }

            waterMarkTextBox1.AutoCompleteCustomSource = items;
        }

        private void SearchBarControl_Load(object sender, EventArgs e)
        {
            waterMarkTextBox1.Focus();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            OpenSearchResults();
        }

        private void waterMarkTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenSearchResults();
            }
        }

        private void waterMarkTextBox1_TextChanged(object sender, EventArgs e)
        {
            OpenSearchResults();
        }
    }
}