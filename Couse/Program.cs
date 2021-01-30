using System;
using System.IO;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";

            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (var line in lines)
                {
                    Console.Write(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An Error occured");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
