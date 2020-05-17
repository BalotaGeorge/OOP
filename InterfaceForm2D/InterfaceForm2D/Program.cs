using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceForm2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerc cerc = new Cerc(5);
            Patrat patrat = new Patrat(10);
            Info(cerc);
            Info(patrat);
            Console.ReadLine();
        }

        public static void Info(IForma2D form)
        {
            Console.WriteLine($"Denumire: {form.Denumire}");
            Console.WriteLine($"Arie: {form.Arie()}");
            Console.WriteLine($"Perimetru: {form.Perimetru()}");
            Console.WriteLine();
        }
    }
}
