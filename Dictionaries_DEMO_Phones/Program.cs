using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_DEMO_Phones
{
    class Program
    {
        static void Main(string[] args)
        {        

            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string command = Console.ReadLine();

            while (command != "stop")
            {
                if (command != "search")
                {

                
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = input[0];
                string phoneNumber = input[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("Има такъв запис. Искате ли да го презапишете? Y/N");
                        var response = Console.ReadLine();

                        if (response == "Y")
                        {
                            phonebook[name] = phoneNumber;
                        }
                        else
                        {
                            phonebook[name] = phoneNumber;
                        }
                    }
                    else
                    {
                        string names = Console.ReadLine();

                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine($"Телефона на {names} е {phonebook[names]}");
                        }
                        else
                        {
                            Console.WriteLine("Не съществува такъв запис");
                        }
                    }
                    }
            }
        }
    }
}
