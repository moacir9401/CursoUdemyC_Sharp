using System;
using System.Collections.Generic;
using System.Linq;
using MultiCastDelegates.Service;

namespace MultiCastDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);


            Console.ReadKey();
        }
    }
}
