using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaAngajat
{
    public interface IAngajat
    {
        string Nume { get; set; }
        string Prenume { get; set; }
        DateTime DataAngajare { get; set; }
    }
}
