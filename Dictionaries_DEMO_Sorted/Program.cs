using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_DEMO_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> dictionary = new SortedDictionary<int, string>();

            dictionary.Add(2, "Kotka");
            dictionary.Add(1, "Kuche");
            dictionary.Add(-1, "Ptica");
            dictionary.Add(7, "Riba");
            dictionary.Add(4, "Gushter");

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key is {kvp.Key} with value {kvp.Value}");
            }

            Console.WriteLine();

            Dictionary<int, string> dictionari = new Dictionary<int, string>();

            dictionari.Add(2, "Kotka");
            dictionari.Add(1, "Kuche");
            dictionari.Add(-1, "Ptica");
            dictionari.Add(7, "Riba");
            dictionari.Add(4, "Gushter");

            foreach (var kvpp in dictionari.OrderBy(kvpp => kvpp.Key))
            {
                Console.WriteLine($"Key is {kvpp.Key} with value {kvpp.Value}");            
            }
        }

        
    }
}
