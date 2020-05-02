using System;
using System.Collections.Generic;

namespace Dictionaries_DEMO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary[1] = "Kotka";
            dictionary[2] = "Kuche"; // Замества съществуващ запис
            dictionary[3] = "Mishka";

            dictionary.Remove(2);

            dictionary.Add(2, "Maimuna"); // Не замества съществуващ запис

            Console.WriteLine(dictionary[2]);

            var animal = dictionary[3]; // Взима стойност на втория елемент в речника. Това е мето Get.

            Console.WriteLine(animal);
        }
    }
}
