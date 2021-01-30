using System;
using GetHashCodeEquals.Entites;

namespace GetHashCodeEquals
{
    class Program
    {
        static void Main(string[] args)
        {

            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client() { Name = "Alex", Email = "maria@gmail.com" };

            // compara o conteudo 
            // neste exemplo esta comparando se o email é igual pelo override da class Client
            Console.WriteLine(a.Equals(b));

            // compara o endereço de memoria
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.ReadKey();
        }
    }
}
