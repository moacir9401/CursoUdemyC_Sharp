using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAbstract.Entities
{
    class Circle:Shape
    {
        public double radius { get; set; }

        public Circle()
        {

        }

        public Circle(Color color,double radius):base(color)
        {
            this.radius = radius;
        }
    }
}
