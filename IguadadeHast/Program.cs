using System;
using System.Collections.Generic;
using IguadadeHast.Entites;

namespace IguadadeHast
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();

            a.Add(new Product("TV",900.0));
            a.Add(new Product("Notebook",1200.0));


            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3,4));
            b.Add(new Point(5,10));


            Product prod = new Product("Notebook", 1200.0);

            // caso estiver comparando o tipo que não possui essas implementações como o tipo referências ele faz a comparação por referências dos objetos
            // mas caso for do tipo valor ele faz a comparação pelo valores dos atributos


            // Embora os conteúdos estejam iguais, o resultado é diferente pelo fato que o contains está comparando um tipo de referência que não possui GetHashCode ou equals
            // para fazer ele compara pelo conteudo do objeto tem que implementar o Equals e GetHashCode dentro do tipo da referência neste caso o Product
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);


            // quando o tipo é struct não é necessario a implementação, ele já vai comparar pelo conteudo e não por refêrencia
            Console.WriteLine(b.Contains(p));


            Console.ReadKey();
        }
    }
}
