using System.Globalization;

namespace projetoLocadora.Entities
{
    class Invoice
    {
        public double Basicpayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicpayment, double tax)
        {
            this.Basicpayment = basicpayment;
            this.Tax = tax;
        }

        public double TotalPayment()
        {
            return Basicpayment + Tax;
        }

        public override string ToString()
        {
            return $"Basic Ptament: {Basicpayment.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                   $"Tax: {Tax.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                   $"Total Payment: {TotalPayment().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
