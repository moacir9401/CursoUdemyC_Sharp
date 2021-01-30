using System.Globalization;

namespace DelegateAction.Entites
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double prince)
        {
            Name = name;
            Price = prince;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
