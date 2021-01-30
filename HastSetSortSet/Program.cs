using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() {0,2,4,5,6,8,10 };

            SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10 };


            // tem como instanciar já adicionando um conjunto de elementos 
            SortedSet<int> c = new SortedSet<int>(a);
            // fazer a uniao com o SortedSet b
            c.UnionWith(b);


            //Interceção
            SortedSet<int> d = new SortedSet<int>(a);
            d.Intersect(b);


            // diferençã de conjunto
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);


            PrintCollectio(e);

            Console.ReadKey();
        }

        static void PrintCollectio<T>(IEnumerable<T> collection)
        {
            foreach (var p in collection)
            {
                Console.Write(p);
            }
        }
    }
}
