using System.ComponentModel;
using System.Drawing;

namespace DedSecDns_Client.Core.Styling.Converters
{
    public class FontConverter : IConverter<Font>
    {
        public override Font Convert(string s)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));

            return (Font)converter.ConvertFromString(s);
        }

        public override string Convert(Font s)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));

            return converter.ConvertToString(s);
        }
    }
}