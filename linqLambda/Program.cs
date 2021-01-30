using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using linqLambda.Entites;


namespace linqLambda
{
    class Program
    {

        static void Print<T>(string mensagem,IEnumerable<T> collection)
        {
            Console.WriteLine(mensagem);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
              new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Price < 900.0 && p.Category.Tier == 1);
            Print("TIER 1 AND PRICE < 900: ",r1);

            var r2 = products.Where(p =>  p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME OF PRODUCTS FROM TOOLS: ", r2);

            var r3 = products.Where(p => p.Name.StartsWith("C")).Select(p => new { p.Name, p.Price, CategoryName =  p.Category.Name });
            Print("NAME STARTED WITH 'C' AMOMY,OUS OBJECT: ", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

            // skip e take é utilizado mais para páginação 
            // o skip ele pula a quantidade de resgistro informado, neste exemplo ele vai começar a mostrar aprtir do 2º registro
            // enquanto o take pega a quantidade total, neste exemplo ele mostrou apenas 4 registro
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", r5);

            // ele mostra o primeiro elemento da lista mas não aceita vazio
            var r6 = products.First();
            Console.WriteLine($"First teste 1: {r6}");
            Console.WriteLine();

            // ele mostra o primeiro elemento da lista mas aceita vazio
            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine($"First or default teste 2: {r7}");
            Console.WriteLine();

            // ele mostra apenas um elemento sua pesquisa der mais que um elemento ele da erro
            var r8 = products.Where(p => p.Id == 3).Single();
            Console.WriteLine($"Single teste 1: {r8}");
            Console.WriteLine();

            // ele mostra apenas um elemento ou nenhum caso sua pesquisa der mais que um elemento ele da erro
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine($"Single or default teste 2: {r9}");
            Console.WriteLine();

            // retorna o maior valor 
            var r10 = products.Max(p => p.Price);
            Console.WriteLine($"Max Price: {r10}");
            Console.WriteLine();

            // retorna o menor valor
            var r11 = products.Min(p => p.Price);
            Console.WriteLine($"Min Price: {r11}");
            Console.WriteLine();

            // retora a soma dos preços da categoria 1
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p=> p.Price);
            Console.WriteLine($"Category 1 Sum Price: {r12}");
            Console.WriteLine();

            // retorna a media dos preços da categoria 1 mas caso a lista estiver vazia retorna um erro
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"Category 1 Average Price: {r13}");
            Console.WriteLine();

            // retorna a media dos preços da categoria 1 mas caso a lista estiver vazia o DefaultIfEmpty implementa o valor padrão informado 0
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Category 5 Average Price: {r14}");
            Console.WriteLine();

            // retora a soma dos preços da categoria 1 utilizando Aggregate para realizar uma soma personalizada, caso a coleção for vazia ele retorna 0.0
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine($"Category 1 Aggregate Sum: {r15}");
            Console.WriteLine();

            // ele faz um agrupamento pela a categoria
            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category,Product> group in r16)
            {
                Console.WriteLine($"Category {group.Key.Name}");
                foreach (var p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
