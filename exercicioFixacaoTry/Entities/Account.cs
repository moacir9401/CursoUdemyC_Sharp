using System;
using exercicioFixacaoTry.Entities.Exceptions;

namespace exercicioFixacaoTry.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {


            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void withdraw(double amount)
        {
            if (Balance <= 0 || amount > WithdrawLimit) throw new DomainException("Withdraw error: The amount exceeds withdraw limit");

            Balance -= amount;
        }

        public void desposit(double amount)
        {
            Balance += amount;
        }
    }
}
