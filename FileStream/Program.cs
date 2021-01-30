using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {

        public static void exampleFile()
        {
            var path = @"c:\temp\file1.txt";

            FileStream fs = null;
            StreamReader sr = null;
            try
            {

                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }


            }
            catch (IOException ex)
            {
                Console.WriteLine("An Error occured");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }

        public static void exampleBlockUsing()
        {
            var path = @"c:\temp\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);

                    }
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine("An Error occured");
                Console.WriteLine(ex.Message);
            }
        }


        public  static void exampleSrteamWrite()
        {
            var sourcePath = @"c:\temp\file1.txt";
            var TargetPath = @"c:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (var sw = File.AppendText(TargetPath))
                {
                    foreach (var line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An Error occured");
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {

            exampleSrteamWrite();
            Console.ReadKey();
        }
    }

}
