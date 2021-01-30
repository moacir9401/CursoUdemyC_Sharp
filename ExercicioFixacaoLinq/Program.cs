using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ExercicioFixacaoLinq.Entites;

namespace ExercicioFixacaoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path:");
            var path = Console.ReadLine();

            Console.Write("Enter Salary:");
            var salaryInical = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            var lines = File.ReadAllLines(path);

            foreach (var item in lines)
            {
                var line = item.Split(',');
                var name = line[0];
                var email = line[1];
                var salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                list.Add(new Employee() { Name = name,Email = email, Salary = salary });

            }

            Console.WriteLine($"Email of people whose salary is more than {salaryInical}");

            var listEmailHigher = list.Where(e => e.Salary > salaryInical).OrderBy(e => e.Email);

            foreach (var item in listEmailHigher)
            {
                Console.WriteLine(item.Email);
            }

            Console.WriteLine($"Sum of salary of people whose starts with 'M': {list.Where(e => e.Name.StartsWith("M")).Sum(e => e.Salary).ToString("F2",CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
