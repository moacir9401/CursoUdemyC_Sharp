using System;
using System.Collections.Generic;
using DelegateAction.Entites;

namespace DelegateAction
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

            list.ForEach(p => { p.Price *= 1.10; Console.WriteLine(p); });

            Console.ReadKey();
        }

    }
}
