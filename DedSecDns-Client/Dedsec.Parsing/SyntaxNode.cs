using Loyc.Syntax;
using System.Collections.Generic;

namespace Dedsec.Parsing
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

        public static LNode CreateCall(LNode name, IEnumerable<LNode> args)
        {
            return F.Call(name, args);
        }

        public static LNode CreateHex(string color)
        {
            return F.Literal("#" + color).WithStyle(NodeStyle.HexLiteral);
        }

        public static LNode CreateID(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return F.Id(id);
            }

            return LNode.Missing;
        }

        public static LNode CreateNum(string val)
        {
            return F.Literal(int.Parse(val));
        }

        public static LNode CreateProp(LNode id, LNode val)
        {
            return F.Tuple(id, val);
        }
    }
}