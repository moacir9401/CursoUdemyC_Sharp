using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.Entities
{
    class Employee
    {
        public string Nome { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }

        public Employee(string nome, int hours, double valuePerHour)
        {
            Nome = nome;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return $"{Nome} - $ {ValuePerHour}";
        }
    }
}
