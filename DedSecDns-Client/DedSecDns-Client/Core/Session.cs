using System;
using System.Collections.Concurrent;

namespace DedSecDns_Client.Core
{
    public static class Session
    {
        public static HashFile Persistent = new HashFile();

        public static void Clear()
        {
            _data.Clear();
        }

        public static T Get<T>(string key)
        {
            return (T)_data[key];
        }

        public static void Init()
        {
            Persistent.Initialize(".session", 50, 100);
        }

        public static void Set(string key, object value)
        {
            _data.AddOrUpdate(key, value, new Func<string, object, object>((_, __) => value));
        }

        private static ConcurrentDictionary<string, object> _data = new ConcurrentDictionary<string, object>();
    }
}