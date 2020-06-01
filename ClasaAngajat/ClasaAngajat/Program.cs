using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaAngajat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../input.txt");
            SomeList<Angajat> angajati = new SomeList<Angajat>();
            foreach (string line in lines)
            {
                string[] data  = line.Split(' ');
                Angajat angajat = new Angajat();
                angajat.Nume = data[0];
                angajat.Prenume = data[1];
                angajat.DataAngajare = DateTime.Parse(data[2]);
                angajati.Add(angajat);
            }

            angajati.Sort((a, b) => a.Nume.CompareTo(b.Nume));
            string[] output = new string[lines.Length];
            for (int i = 0; i < output.Length; i++)
                output[i] = $"{angajati[i].Nume} {angajati[i].Prenume} {angajati[i].DataAngajare.ToShortDateString()}";
            File.WriteAllLines("../../outputAlfabetic.txt", output);

            angajati.Sort((a, b) => (DateTime.Now.Year - b.DataAngajare.Year).CompareTo(DateTime.Now.Year - a.DataAngajare.Year));
            for (int i = 0; i < output.Length; i++)
                output[i] = $"{angajati[i].Nume} {angajati[i].Prenume} {DateTime.Now.Year - angajati[i].DataAngajare.Year}";
            File.WriteAllLines("../../outputVechime.txt", output);
        }
    }
}
