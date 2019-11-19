using System;
using System.Collections.Generic;
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
                if (type.IsAssignableFrom(typeof(ISearchableCommand)))
                {
                    Add((ISearchableCommand)Activator.CreateInstance(type));
                }
            }
        }

        private static List<ISearchableCommand> _commands = new List<ISearchableCommand>();
    }
}