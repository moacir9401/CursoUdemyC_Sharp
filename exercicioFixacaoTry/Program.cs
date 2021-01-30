using System;
using exercicioFixacaoTry.Entities;
using exercicioFixacaoTry.Entities.Exceptions;
using System.Globalization;

namespace exercicioFixacaoTry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                var number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                var holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                var initial = double.Parse(Console.ReadLine());

                Console.WriteLine("Withdraw limit: ");
                var WithdrawLimit = double.Parse(Console.ReadLine());

                var acc = new Account(number, holder, initial, WithdrawLimit);

                Console.WriteLine("Enter amount for withdraw:");
                var withdraw = double.Parse(Console.ReadLine());

                acc.withdraw(withdraw);

                Console.WriteLine($"new balance: {acc.Balance.ToString("F2",CultureInfo.InvariantCulture)}");

            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
