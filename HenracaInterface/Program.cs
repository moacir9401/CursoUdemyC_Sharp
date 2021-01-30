
using System;
using HenracaInterface.Entities;
using HenracaInterface.Entities.Enums;

namespace HenracaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, color = Color.white };
            IShape s2 = new Retancle() { Width = 3.5, Height = 4.2, color = Color.black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
