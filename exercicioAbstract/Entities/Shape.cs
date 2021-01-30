using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAbstract.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape()
        {

        }

        protected Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
    }
}
