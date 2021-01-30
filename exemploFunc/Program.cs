using System;
using System.Collections.Generic;
using exemploFunc.Entites;
using System.Linq;

namespace exemploFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));


            List<string> result = list.Select(p =>  p.Name.ToUpper()).ToList();

            result.ForEach(p => Console.WriteLine(p));

            Console.ReadKey();

        }

    }
}
