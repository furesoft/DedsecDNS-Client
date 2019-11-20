namespace DedSecDns_Client.Core.Styling
{
    public abstract class IConverter<TOut>
    {
        public abstract TOut Convert(string s);

        public abstract string Convert(TOut s);
    }
}