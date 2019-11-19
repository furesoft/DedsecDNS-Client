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

        private void SearchBarControl_Load(object sender, EventArgs e)
        {
            waterMarkTextBox1.Focus();

            var trie = new Trie<string>();

            foreach (var item in CommandRepository.GetAllNames())
            {
                trie.Add(item.Key, item.Value);
            }

            var result = trie.Retrieve(waterMarkTextBox1.Text);
            var items = new AutoCompleteStringCollection();

            foreach (var item in result)
            {
                items.Add(item);
            }

            waterMarkTextBox1.AutoCompleteCustomSource = items;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            CommandRepository.InvokeCommand(waterMarkTextBox1.Text);
        }

        private void waterMarkTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CommandRepository.InvokeCommand(waterMarkTextBox1.Text);
            }
        }
    }
}