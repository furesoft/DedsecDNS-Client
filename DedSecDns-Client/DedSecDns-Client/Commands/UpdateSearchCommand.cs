using DedSecDns_Client.Core;

namespace DedSecDns_Client.Commands
{
    public class UpdateSearchCommand : ISearchableCommand
    {
        public int ID { get; set; }
        public string Key => "update";
        public string Title => "Nach Update suchen";

        public void Invoke()
        {
            Updater.InstallIfAvailable();
        }
    }
}