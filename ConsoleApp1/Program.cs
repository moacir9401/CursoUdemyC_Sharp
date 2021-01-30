using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_ABSTRACT.Entities;


namespace POO_ABSTRACT
{
    class Program
    {
        public void Casting()
        {
            Account acc = new Account(1001, "alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "maria", 0.0, 500.0);

            //UPPCASTING CONVERSÃO DA SUBCLASSE PARA SUPER CLASSE
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "ana", 0.0, 0.01);

            //DOWNCASTING CONVERSÃO DA SUPER CLASSE PARA SUBCLASSE
            BusinessAccount acc4 = (BusinessAccount)acc2;


            // o is verifica se o objeto e do mesmo tipo da classe BusinessAccount
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }


            // o as serve como o casting
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
            }

        }

        public static void sobrepossicao()
        {
            Account acc1 = new Account(1001, "alex", 500.0);
            Account acc2 = new SavingsAccount(1002,"Anna",500.0,0.01);

            acc1.withdraw(10.0);
            acc2.withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }

        static void Main(string[] args)
        {

            sobrepossicao();
            Console.ReadKey();

        }
    }
}
