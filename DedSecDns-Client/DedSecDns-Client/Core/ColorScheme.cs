using DedSecDns_Client.Core.Styling.Parser;
using DedSecDns_Client.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DedSecDns_Client.Core
{
    internal class ColorScheme
    {
        public static ColorScheme Default = Load("default", Resources.default_colors);
        public string Name { get; set; }
        public IEnumerable<CssParserDeclaration> Style { get; set; }

        public static void Apply(ColorScheme scheme, Control c)
        {
            c.BackColor = scheme.GetColor("background");

            foreach (var btn in c.Controls.OfType<XanderUI.XUIButton>())
            {
                btn.BackColor = scheme.GetColor("dark");
            }
        }

        public static ColorScheme Load(string name, string source)
        {
            var style = new CssParser().ParseAll(source);

            return new ColorScheme { Name = name, Style = style };
        }

        public Color GetColor(string key)
        {
            foreach (var decl in Style)
            {
                if (decl.Property == key)
                {
                    return new Styling.ColorConverter().Convert(decl.Value);
                }
            }

            return SystemColors.Control;
        }
    }
}