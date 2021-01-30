using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using POO_ABSTRACT.Entities;


namespace POO_ABSTRACT
{
    class Program
    {
      

        static void Main(string[] args)
        {

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "alexx", 500.0, 0.01));
            list.Add(new BusinessAccount(1002,"Maria", 500.0,400.0));
            list.Add(new SavingsAccount(1003, "bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Anna", 500.0, 500.0));

            double sum = 0.0;
            list.ForEach(acc => sum += acc.Balance);

            Console.WriteLine($"total balance: {sum.ToString("F2",CultureInfo.InvariantCulture)}");

            list.ForEach(acc => acc.withdraw(10.0));


            list.ForEach(acc => Console.WriteLine($"updated balance for account {acc.Number}: {acc.Balance.ToString("F2",CultureInfo.InvariantCulture)}"));

            Console.ReadKey();

        }
    }
}
