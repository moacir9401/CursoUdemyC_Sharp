using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using exercicioFixacao.Entities;

namespace exercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProduct = new List<Product>();
            
            Product objProduct = new Product();

            Console.Write("Enter the number of products:");
            var numProduct = int.Parse(Console.ReadLine());

            for (int i = 0; i < numProduct; i++)
            {
                Console.WriteLine($"Product #{listProduct.Count + 1} data:");
                Console.Write("Common, used or imported (c/u/i) ?");
                var common = Console.ReadLine();

                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Price: ");
                var price = double.Parse(Console.ReadLine());


                if (common.Equals("i"))
                {
                    Console.Write("Customs fee: ");
                    var customsFree = double.Parse(Console.ReadLine());

                    objProduct = new ImportedProduct(name, price, customsFree);

                }
                else if (common.Equals("u"))
                {
                    Console.Write("ManuFacture date (DD/MM/YYYY): ");
                    var manuFactureDate = DateTime.Parse(Console.ReadLine());

                    objProduct = new UsedProduct(name, price, manuFactureDate);
                }
                else if (common.Equals("c"))
                {
                    objProduct = new Product(name, price);
                }

                listProduct.Add(objProduct);

            }

            listProduct.ForEach(item => Console.WriteLine(item.PrinceTag()));

            Console.ReadKey();

        }
    }
}
