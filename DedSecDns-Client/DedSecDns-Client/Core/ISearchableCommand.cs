namespace DedSecDns_Client.Core
{
    public interface ISearchableCommand : ICommand
    {
        string Key { get; }
        string Title { get; }
    }
}