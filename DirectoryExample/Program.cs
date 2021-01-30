using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\mYFolder\";

            try
            {

                // listar diretorio
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");

                foreach (var s in folders)
                {
                    Console.WriteLine(s);
                }


                // listar diretorio
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");

                foreach (var s in files)
                {
                    Console.WriteLine(s);
                }

                // criar diretorio
                Directory.CreateDirectory($@"{path}\newFolder");

                // Deletar direotrio
                Directory.Delete($@"{path}\newFolder");

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
