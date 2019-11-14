using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSecDns_Client.Core
{
    public static class Session
    {
        public static T Get<T>(string key)
        {
            return (T)_data[key];
        }

        public static void Set(string key, object value)
        {
            _data.AddOrUpdate(key, value, new Func<string, object, object>((_, __) => value));
        }

        private static ConcurrentDictionary<string, object> _data = new ConcurrentDictionary<string, object>();
    }
}