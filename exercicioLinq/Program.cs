using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using exercicioLinq.Entites;
using System.Threading.Tasks;

namespace exercicioLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter full file path:");
            var path = Console.ReadLine();


            var lines = File.ReadAllLines(path);


            foreach (var item in lines)
            {
                var line = item.Split(',');
                var name = line[0];
                var price = double.Parse(line[1], CultureInfo.InvariantCulture);

                list.Add(new Product() { Name = name, Price = price});

            }

            var valueMedium = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average price: {valueMedium.ToString("F2")}");

            var listDescending = list.Where(p => p.Price < valueMedium).OrderByDescending(p => p.Name);

            foreach (var item in listDescending)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
