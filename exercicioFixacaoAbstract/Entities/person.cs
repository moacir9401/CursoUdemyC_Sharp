using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacaoAbstract.Entities
{
    abstract class person
    {
        public string name { get; set; }
        public double AnualIncome { get; set; }

        public person()
        {

        }

        protected person(string name, double anualIncome)
        {
            this.name = name;
            this.AnualIncome = anualIncome;
        }

        public abstract double CalcTax();
    }
}
