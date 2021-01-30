using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemaDiamante.Devices
{
    class Printer:Device,IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printer print result {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer processing: {document}");
        }

         
    }
}
