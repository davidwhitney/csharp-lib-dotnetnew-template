using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ToolTemplate
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            if (args.Length == 0)
            {
                var versionString = Assembly.GetEntryAssembly()
                                        .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                        .InformationalVersion
                                        .ToString();

                Console.WriteLine($"ToolTemplate v{versionString}");
                Console.WriteLine("-------------");
                Console.WriteLine("\nUsage:");
                Console.WriteLine("  ToolTemplate <message>");
                return;
            }

            Console.WriteLine(string.Join(' ', args));
        }
    }
}
