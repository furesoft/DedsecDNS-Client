using DedSecDns_Client.Core;
using nUpdate.Updating;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace DedSecDns_Client.Commands
{
    public class UpdateSearchCommand : ISearchableCommand
    {
        public int ID { get; set; }
        public string Key => "update";
        public string Title => "Nach Update suchen";

        public void Invoke()
        {
            var manager = Updater.manager;

            if (manager.SearchForUpdates())
            {
                MessageBox.Show("Update wurde gefunden. Das Programm wird zur installation neu gestartet");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Kein Update gefunden");
            }
        }
    }
}