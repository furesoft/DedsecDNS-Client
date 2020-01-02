using Dedsec.Parsing;
using DedSecDns_Client.Core.Styling.Parser;
using DedSecDns_Client.Properties;
using Loyc.Syntax;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XanderUI;

namespace DedSecDns_Client.Core
{
    internal class ColorScheme
    {
        public static ColorScheme Default = Load("default", Resources.default_colors);
        public string Name { get; set; }
        public LNode Style { get; set; }

        public static void Apply(ColorScheme scheme, Control c)
        {
            if (c is Form)
            {
                c.BackColor = Color.FromArgb(255, scheme.GetColor("background"));
            }
            else
            {
                c.BackColor = scheme.GetColor("background");
            }
            foreach (var btn in c.Controls.OfType<XUIWidgetPanel>())
            {
                btn.BackColor = scheme.GetColor("dark");
            }
            foreach (var btn in c.Controls.OfType<XUIButton>())
            {
                btn.BackColor = scheme.GetColor("dark");
            }
        }

        public static ColorScheme Load(string name, string source)
        {
            var p = new ColorSchemeParser();
            var style = p.Parse(source);

            return new ColorScheme { Name = name, Style = style };
        }

        public Color GetColor(string key)
        {
            foreach (var decl in Style.Args)
            {
                var k = decl.Args.First();
                var v = decl.Args[1];

                if (k.Name.Name == key)
                {
                    return (Color)v.Value;
                }
            }

            return SystemColors.Control;
        }
    }
}