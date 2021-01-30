using System;
using HenracaInterface.Entities.Enums;

namespace HenracaInterface.Entities
{
   abstract class AbstractShape: IShape
    {
        public Color color { get; set; }

        public abstract double Area();
    }
}
