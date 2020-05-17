using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceForm2D
{
    public class Cerc : IForma2D
    {
        public string Denumire => "Cerc";
        public float radius;
        public Cerc(float radius)
        {
            this.radius = radius;
        }

        public float Arie()
        {
            return (float)Math.PI * radius * radius;
        }

        public float Perimetru()
        {
            return 2f * (float)Math.PI * radius;
        }
    }
}
