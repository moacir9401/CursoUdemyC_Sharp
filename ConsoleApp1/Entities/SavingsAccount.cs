using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_ABSTRACT.Entities;

namespace POO_ABSTRACT.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        // o sealed sela o metodo e ele não pode ser sobreescrita novamente (apenas em metodos sobrescritos)
        // ovrride serve para sobreescrever o metodo
        public sealed override void withdraw(double amount)
        {
            //Reaproveita a função da super classe
            base.withdraw(amount);
            Balance -= 2.0;
        }

        public void updateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
