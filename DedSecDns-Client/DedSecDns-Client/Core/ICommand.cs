namespace DedSecDns_Client.Core
{
    public interface ICommand
    {
        int ID { get; set; }

        void Invoke();
    }
}