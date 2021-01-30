using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacaoInterface.Entites
{
    class Contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue {get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
        }
    }
}
