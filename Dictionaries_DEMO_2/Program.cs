using System;
using System.Collections.Generic;

namespace Dictionaries_DEMO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionaries = new Dictionary<string, string>();
            
            dictionaries.Add("hg123", "bag");
            dictionaries.Add("hj765", "glasses");
            dictionaries.Add("ui897", "hat");
            dictionaries.Add("po987", "knife");

            Console.WriteLine("What is your code?");

            string code = Console.ReadLine();

            if (dictionaries.ContainsKey(code))
            {
                Console.WriteLine(dictionaries[code]);
            }
            else
            {
                Console.WriteLine("Sorry.");
            }


        }
    }
}
