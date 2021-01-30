using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookies = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            var path = Console.ReadLine();

            var lines = File.ReadAllLines(path);

            foreach (var item in lines)
            {
                var line = item.Split(',');

                if (cookies.ContainsKey(line[0]))
                    cookies[line[0]] += int.Parse(line[1]);
                else
                    cookies[line[0]] = int.Parse(line[1]);
            }

            foreach (var item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
