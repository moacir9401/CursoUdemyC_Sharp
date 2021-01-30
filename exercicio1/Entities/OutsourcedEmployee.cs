using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.Entities
{
    class OutsourcedEmployee : Employee
    {

        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string nome, int hours, double valuePerHour, double additionalCharge)
            : base(nome, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return base.payment() + AdditionalCharge + (AdditionalCharge * 0.100);

        }
    }
}
