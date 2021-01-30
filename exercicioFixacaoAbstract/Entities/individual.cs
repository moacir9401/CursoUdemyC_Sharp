using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacaoAbstract.Entities
{
    class individual : person
    {
        public double HealthExpenditures { get; set; }

        public individual()
        {

        }

        public individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalcTax()
        {
            if (AnualIncome < 20000)
            {
                return AnualIncome * 1.015;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;

            }
        }
    }
}
