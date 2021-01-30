using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioFixacao.Entities
{
    class Product
    {
        public string name { get; set; }
        public double prince { get; set; }

        public Product()
        {

        }

        public Product(string name, double prince)
        {
            this.name = name;
            this.prince = prince;
        }

        public virtual string PrinceTag()
        {
            return $"{name} $ {prince.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
