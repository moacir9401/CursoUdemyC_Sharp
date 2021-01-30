using System;
using System.Collections.Generic;
using System.Globalization;
using exercicioAbstract.Entities;

namespace exercicioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();



            Console.WriteLine("Enter the number of shapes:");
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Shape #{list.Count + 1} data:");

                Console.Write("Rectangle or Circle (r/c)");
                var option = Console.ReadLine().ToLower();

                Console.Write("Color (Black,Blue,Red): ");

                Enum.TryParse<Color>(Console.ReadLine(), out Color color);

                if (option.Equals("r"))
                {
                    Console.Write("Width: ");
                    var width = int.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    var height = int.Parse(Console.ReadLine());

                    list.Add(new Rectangle(color, width, height));

                }
                else if (option.Equals("c"))
                {
                    Console.Write("Radius: ");
                    var radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(color, radius));
                }

            }



            Console.WriteLine("SHAPE AREAS: ");
            list.ForEach(shape => Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture)));


            Console.ReadKey();

        }
    }
}
