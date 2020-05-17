using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceForm2D
{
    public class Patrat : IForma2D
    {
        public string Denumire => "Patrat";
        public float length;

        public Patrat(float length)
        {
            this.length = length;
        }

        public float Arie()
        {
            return length * length;
        }

        public float Perimetru()
        {
            return 4f * length;
        }
    }
}
