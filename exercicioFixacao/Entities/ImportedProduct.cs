using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double prince, double customsFree)
            :base(name, prince)
        {
            CustomsFree = customsFree;
            base.prince = totalPrice();
        }

        public override string PrinceTag()
        {
            return $"{base.PrinceTag()} (Customs fee: $ {CustomsFree})";
        }

        public double totalPrice()
        {
            return prince + CustomsFree;
        }
    }
}
