using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao.Entities
{
    class UsedProduct:Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double prince,DateTime manufactureDate)
            :base(name,prince)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PrinceTag()
        {
            return $"{name} (used) $ {prince.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToShortDateString()})";
        }
    }
}
