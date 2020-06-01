using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaAngajat
{
    public class Angajat : IAngajat
    {
        private string _nume;
        private string _prenume;
        private DateTime _dataAngajare;
        public string Nume { get { return _nume; } set { _nume = value; } }
        public string Prenume { get { return _prenume; } set { _prenume = value; } }
        public DateTime DataAngajare { get { return _dataAngajare; } set { _dataAngajare = value; } }

    }
}
