using System;
using System.Globalization;
using Calculation.Services;


namespace Calculation
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 12;

            BinaryNumericOperation op = CalculationService.Sum;


            double result = op(a,b);
            Console.WriteLine(result);

            
            Console.ReadKey();
        }
    }
}
