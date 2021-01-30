using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAbstract.Entities
{
    class Rectangle:Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(Color color,double width, double height):base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
