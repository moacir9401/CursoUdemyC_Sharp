using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLocadora.Services
{
    class BrazilTaxService:ITaxServices
    {

        public double tax(double amount)
        {
            if (amount <= 100.0)
                return amount * 0.2;
            else
                return amount * 0.15;
        }
    }
}
