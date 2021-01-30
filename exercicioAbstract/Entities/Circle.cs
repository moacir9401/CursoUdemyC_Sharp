using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAbstract.Entities
{
    class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(Color color,double radius):base(color)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
