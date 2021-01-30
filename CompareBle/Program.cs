using System;
using System.Collections.Generic;
using System.IO;
using Compareble.Entites;

namespace Compareble
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    var list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (var emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }

                

            }
            catch (Exception)
            {

                throw;
            }

            Console.ReadKey();
        }
    }
}
