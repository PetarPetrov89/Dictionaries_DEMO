using System;
using System.Collections.Generic;

namespace Dictionaries_DEMO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the US Embassy in Sofia!");

            Dictionary<int, List<string>> dictionaries = new Dictionary<int, List<string>>();

            Console.WriteLine("Please enter type of work.");
            string typeOfWork = Console.ReadLine();

            while (typeOfWork == "Welcome")
            {
                Random rnd = new Random();

                var talon = rnd.Next(1, 200);

                while (dictionaries.ContainsKey(talon))
                {
                    talon = rnd.Next(1, 200);
                }

                Console.WriteLine($"Your code is {talon}");
                dictionaries.Add(talon, new List<string>());

                Console.WriteLine("What is your belongings?");

                string belonging = Console.ReadLine();

                while (belonging != "stop")
                {
                    dictionaries[talon].Add(belonging);

                    belonging = Console.ReadLine();
                }
                Console.WriteLine("Please enter type of work.");
                typeOfWork = Console.ReadLine();
            }


            Console.WriteLine("What is your code");

            int visitorTalon = int.Parse(Console.ReadLine());

            if (dictionaries.ContainsKey(visitorTalon))
            {
                foreach (var belonging in dictionaries[visitorTalon])
                {
                    Console.WriteLine(belonging);
                }
            }
            else
            {
                Console.WriteLine("Sorry you have not ");
            }
        }
    }
}
