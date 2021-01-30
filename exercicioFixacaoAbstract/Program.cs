using System;
using System.Collections.Generic;
using exercicioFixacaoAbstract.Entities;
using System.Globalization;

namespace exercicioFixacaoAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<person> list = new List<person>();
             

            Console.Write("Enter the number of tax payers:");
            var numPayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numPayers; i++)
            {
                Console.WriteLine($"Tax payer #{list.Count + 1} data:");

                Console.Write("Individual or company (i/c) ?");
                var option = Console.ReadLine();

                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Anual Income: ");
                var anualIncome = double.Parse(Console.ReadLine());


                if (option.Equals("i"))
                {
                    Console.Write("Health expenditures: ");
                    var health = double.Parse(Console.ReadLine());


                   list.Add(new individual(name, anualIncome, health));

                }
                else if (option.Equals("c"))
                {
                    Console.Write("Number of employess: ");
                    var numEmployees = int.Parse(Console.ReadLine());

                    list.Add(new company(name, anualIncome, numEmployees));
                }

            }

            list.ForEach(item => Console.WriteLine($"{item.name}: $ {item.CalcTax().ToString("F2",CultureInfo.InvariantCulture)}"));

            var sum = 0.0;

            list.ForEach(item => sum += item.CalcTax());

            Console.WriteLine($"Total Taxes $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
