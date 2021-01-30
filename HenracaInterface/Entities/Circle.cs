using System;
using System.Globalization;

namespace HenracaInterface.Entities
{
    class Circle: AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Clircle Color = {color}, " +
                $"radius = {Radius.ToString("F2",CultureInfo.InvariantCulture)}, " +
                $"area = {Area().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
