using System;
using System.IO;

namespace examplePath
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\mYFolder\file1.txt";

            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"GetFileName: b{ Path.GetFileName(path)}");
            Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");
            Console.ReadKey();
        }
    }
}
