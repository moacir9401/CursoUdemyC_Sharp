using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // convertendo para mostrar em formato decimal a diferencia de dias em relação a data atual em dias e horas
            DateTime dt = new DateTime(2020, 12, 30, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());


            // Cortando a string pelo tamanho informado
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

            Console.ReadKey();

        }

        

    }
}
