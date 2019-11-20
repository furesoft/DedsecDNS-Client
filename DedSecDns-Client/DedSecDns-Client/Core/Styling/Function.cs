using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DedSecDns_Client.Core.Styling
{
    public class Function
    {
        public List<object> Arguments;
        public string Name;

        public object this[int i]
        {
            get { return Arguments[i]; }
        }

        public static bool IsFunction(string s)
        {
            return Regex.IsMatch(s, @"[A-Za-z0-9]\(.*?((,)*.*?)+\)");
        }

        public static Function Parse(string s)
        {
            var f = new Function { Name = s.Split('(')[0] };

            string args = s.Remove(0, f.Name.Length + 1);
            args = args.Remove(args.Length - 1, 1);

            foreach (string arg in args.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string a = arg;
                if (a.StartsWith(" ")) a = a.Remove(0, 1);
                f.Arguments.Add(f.Extract(a));
            }

            return f;
        }

        public T Arg<T>(int i)
        {
            return (T)Arguments[i];
        }

        protected Function()
        {
            Arguments = new List<object>();
        }

        private object Extract(string s)
        {
            object r = null;
            if (IsString(s))
            {
                if (s.EndsWith("'"))
                    r = s.Remove(s.Length - 1, 1);
                if (s.StartsWith("'"))
                    r = r.ToString().Remove(0, 1);
            }
            if (IsNumber(s))
            {
                r = double.Parse(s, new NumberFormatInfo { NumberDecimalSeparator = "." });
            }
            if (IsByte(s))
            {
                r = byte.Parse(s, new NumberFormatInfo { NumberDecimalSeparator = "." });
            }
            return r;
        }

        private bool IsArray(string s)
        {
            return s.StartsWith("[") && s.EndsWith("]");
        }

        private bool IsByte(string s)
        {
            byte d;
            return byte.TryParse(s, out d);
        }

        private bool IsDict(string s)
        {
            return s.StartsWith("{") && s.EndsWith("}");
        }

        private bool IsNumber(string s)
        {
            double d;
            return double.TryParse(s, out d);
        }

        private bool IsString(string s)
        {
            return s.StartsWith("'") && s.EndsWith("'");
        }
    }
}