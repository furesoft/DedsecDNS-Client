using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DedSecDns_Client.Core
{
    public static class CommandRepository
    {
        public static void Add(ISearchableCommand cmd)
        {
            _commands.Add(cmd);
        }

        public static void Collect()
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterfaces().Contains(typeof(ISearchableCommand)))
                {
                    Add((ISearchableCommand)Activator.CreateInstance(type));
                }
            }
        }

        public static Dictionary<string, string> GetAllNames()
        {
            var result = new Dictionary<string, string>();

            foreach (var item in _commands)
            {
                result.Add(item.Key, item.Title);
            }

            return result;
        }

        public static void InvokeCommand(string title)
        {
            foreach (var cmd in _commands)
            {
                if (cmd.Title == title)
                {
                    cmd.Invoke();
                }
            }
        }

        private static List<ISearchableCommand> _commands = new List<ISearchableCommand>();
    }
}