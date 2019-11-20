using DedSecDns_Client.Core.Styling.Parser;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DedSecDns_Client.Core.Styling
{
    internal class StyleChanger
    {
        [DebuggerStepThrough]
        public static void Execute(string source, Control view)
        {
            IEnumerable<CssParserRule> p = new CssParser().ParseAll(source);
            foreach (CssParserRule cssParserRule in p)
            {
                foreach (string selector in cssParserRule.Selectors)
                {
                    foreach (Control bb in view.Controls)
                    {
                        ExecuteQuery(bb, cssParserRule);
                    }
                }
            }
        }

        private static void ExecuteQuery(Control bbb, CssParserRule cssParserRule)
        {
            foreach (CssParserDeclaration d in cssParserRule.Declarations)
            {
                var prop = bbb.GetType().GetProperty(d.Property);
                if (prop != null)
                {
                    if (prop.PropertyType.Name == typeof(Color).Name)
                        prop.SetValue(bbb, new Converters.ColorConverter().Convert(d.Value));
                    if (prop.PropertyType.Name == typeof(Font).Name)
                        prop.SetValue(bbb, new Converters.FontConverter().Convert(d.Value));
                    if (prop.PropertyType.Name == typeof(Image).Name)
                        prop.SetValue(bbb, new Converters.ImageConverter().Convert(d.Value));
                }
            }
        }
    }
}