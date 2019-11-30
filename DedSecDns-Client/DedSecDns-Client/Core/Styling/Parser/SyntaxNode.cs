using Loyc.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSecDns_Client.Core.Styling.Parser
{
    public static class SyntaxNode
    {
        public static LNodeFactory F = new LNodeFactory(EmptySourceFile.Default);

        public static LNode Combine(LNode f, LNode s)
        {
            if (s.IsCall && s.Name == CodeSymbols.AltList)
            {
                var res = new List<LNode>();
                res.Add(f);
                res.AddRange(s.Args);

                return F.List(res.ToArray());
            }

            return F.List(f, s);
        }

        public static LNode Combine(LNode f, IEnumerable<LNode> s)
        {
            var r = new List<LNode>();
            r.Add(f);
            r.AddRange(s);

            return F.List(r);
        }

        public static IEnumerable<LNode> Combine(LNode v)
        {
            return F.List(v);
        }

        public static LNode CreateID(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return F.Id(id);
            }

            return LNode.Missing;
        }
    }
}