using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_DEMO_Hasg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 4, 2, 5, 2, 3, 0 };

            HashSet<int> hashNumbers = new HashSet<int>() { 2, 3, 4, 2, 5, 2, 3, 0 };

            SortedSet<int> sortedNumbers = new SortedSet<int>() { 2, 3, 4, 2, 5, 2, 3, 0 };

            Console.WriteLine(string.Join(",",numbers));
            Console.WriteLine(string.Join(",", hashNumbers));
            Console.WriteLine(string.Join(",", sortedNumbers));

        } 
    }
}
