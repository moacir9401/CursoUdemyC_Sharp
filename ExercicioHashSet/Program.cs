using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using ExercicioHashSet.Entites;

namespace ExercicioHashSet
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write($"Enter File full path:");
            string path = Console.ReadLine();


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(' ');
                        var UserName = line[0];
                        var Instant = line[1];

                        set.Add(new LogRecord { UserName = UserName, Instant = DateTime.Parse(Instant, CultureInfo.InvariantCulture) });

                    }
                    Console.WriteLine($"Total Users: {set.Count}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
