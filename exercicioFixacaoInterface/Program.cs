using System;
using exercicioFixacaoInterface.Service;
using System.Globalization;
using exercicioFixacaoInterface.Entites;

namespace exercicioFixacaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.WriteLine("Number:");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm):");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Contract value:");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter number of installments: ");
            var moths = int.Parse(Console.ReadLine());

            var contrato = new Contract(number,date,totalValue);

            ContractService contractService = new ContractService(new PayPalService());
            contractService.processContract(contrato,moths);

            Console.ReadKey();
        }
    }
}
