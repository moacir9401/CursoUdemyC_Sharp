using System.Globalization;

namespace Comparation.Entites
{
    class Product
    {
        public string Name { get; set; }
        public double Prince { get; set; }

        public Product(string name, double prince)
        {
            Name = name;
            Prince = prince;
        }

        public override string ToString()
        {
            return $"{Name}, {Prince.ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}
