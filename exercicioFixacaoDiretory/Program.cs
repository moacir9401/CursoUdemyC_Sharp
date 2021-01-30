using System;
using System.Collections.Generic;
using System.IO;

namespace exercicioFixacaoDiretory
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = "C:/temp/file1.csv";
            var TargetPath = @"c:/temp/out/";

            string[] file1 = File.ReadAllLines(path);

            if (!Directory.Exists(TargetPath))
            {
                Directory.CreateDirectory(TargetPath);
            }

            using (var sw = File.AppendText($"{TargetPath}/summary.csv"))
            {

                foreach (var item in file1)
                {
                    string[] itens = item.Split(';');
                    sw.WriteLine($"{itens[0]};{int.Parse(itens[1])*int.Parse(itens[2])}");
                }
            }


                Console.WriteLine(file1[0]);
                Console.ReadKey();
        }
    }
}
