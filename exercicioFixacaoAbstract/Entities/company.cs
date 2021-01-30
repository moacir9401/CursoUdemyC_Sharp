using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacaoAbstract.Entities
{
    class company:person
    {

        public int numberEmployees { get; set; }

        public company()
        {

        }

        public company(string name, double anulIncome,int numberEmployees):base(name,anulIncome)
        {
            this.numberEmployees = numberEmployees;
        }

        public override double CalcTax()
        {
            if (numberEmployees > 10)
                return AnualIncome * 0.14;
            else
                return AnualIncome * 0.16;
        }
    }
}
