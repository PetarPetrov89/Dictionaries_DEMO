using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_DEMO_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> StudentsGrades = new Dictionary<string, double[]>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Моля въведете факултетен номер!");
                var fakNomer = Console.ReadLine();

                StudentsGrades[fakNomer] = new double[5];

                Console.WriteLine("Моля въведете оценките на студента!");
                var grades = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                StudentsGrades[fakNomer] = grades;
            }

            foreach (var kvpStudentsGrades in StudentsGrades)
            {
                var fakNumber = kvpStudentsGrades.Key;
                double[] studentGrades = kvpStudentsGrades.Value;
                double averageGrade = studentGrades.Average();

                Console.WriteLine(string.Join(',', studentGrades));

                Console.WriteLine($"Student with Fak. Nomer {fakNumber} has average score {averageGrade}");


            }
        }
    }
}
