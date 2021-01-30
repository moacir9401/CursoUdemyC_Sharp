using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            //especificar a base de dados
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // definir a expressão da consulta
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // executar a consulta
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
