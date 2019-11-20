using System.Collections.Generic;

namespace DedSecDns_Client.Core.Styling.Parser
{
    /// <summary>
    /// Class to hold information for single CSS rule.
    /// </summary>
    public class CssParserRule
    {
        public IEnumerable<CssParserDeclaration> Declarations { get; set; }

        public string Media { get; set; }

        public IEnumerable<string> Selectors { get; set; }

        public CssParserRule(string media)
        {
            Selectors = new List<string>();
            Declarations = new List<CssParserDeclaration>();
            Media = media;
        }
    }
}