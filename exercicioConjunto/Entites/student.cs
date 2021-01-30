using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioConjunto.Entites
{
    class student
    {
        public int Registration { get; set; }

        public override int GetHashCode()
        {
            return Registration.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is student)) return false;

            var other = obj as student;

            return Registration.Equals(other.Registration);
        }
    }
}
