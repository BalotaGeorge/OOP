using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceForm2D
{
    public interface IForma2D
    {
        string Denumire { get; }
        float Arie();
        float Perimetru();
    }
}
