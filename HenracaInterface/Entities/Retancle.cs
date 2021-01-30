using System;
using System.Globalization;

namespace HenracaInterface.Entities
{
    class Retancle: AbstractShape
    {

        public  double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width* Height;
        }

        public override string ToString()
        {
            return $"Clircle Color = {color}, " +
                $"width = {Width.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Height = {Height.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
