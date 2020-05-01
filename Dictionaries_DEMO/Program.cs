using System;
using System.Collections.Generic;

namespace Dictionaries_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionaries = new Dictionary<int, string>();
            dictionaries.Add(1, "name");
            dictionaries.Add(2, "surname");
            dictionaries.Add(8, "kotka");
            dictionaries.Add(4, "kuche");
            dictionaries.Add(7, "dvor");
            dictionaries.Add(6, "BBQ");

            foreach (var kvp in dictionaries)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }
            
            
            //System.Console.WriteLine(dictionaries);
            //new KeyValuePair<int, string>(2, "name");
        }
    }
}
