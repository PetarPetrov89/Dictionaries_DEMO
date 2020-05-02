using System;
using System.Collections.Generic;

namespace Dictionaries_DEMO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вместо ContainsKey може да се използва.
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary[1] = "Kotka";
            dictionary[1] = "Kuche";

            Console.WriteLine(dictionary[1]);
        }
    }
}
