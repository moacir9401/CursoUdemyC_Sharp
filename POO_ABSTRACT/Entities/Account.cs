using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ABSTRACT.Entities
{
    abstract class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }


        // o virtual serve para informar que esse metodo pode ser sobrescrito ou sopreposto
        public virtual void withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void desposit(double amount)
        {
            Balance += amount;
        }
    }
}
