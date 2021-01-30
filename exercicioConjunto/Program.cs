using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using exercicioConjunto.Entites;

namespace exercicioConjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<student> set = new HashSet<student>();
            var course = new string[] { "A", "B", "C" };

            foreach (var item in course)
            {
                Console.Write($"How many students for course {item}?");
                var qtd = int.Parse(Console.ReadLine());
                
                for (int i = 0; i < qtd; i++)
                {
                    set.Add(new student { Registration = int.Parse(Console.ReadLine()) });
                }
            }

            Console.WriteLine($"Total students: {set.Count}");

            Console.ReadKey();
        }
    }
}
