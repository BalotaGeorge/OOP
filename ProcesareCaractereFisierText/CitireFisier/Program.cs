using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireFisier
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args.Length > 0 ? args[0] : "";
            string[] lines;
            if (path == "")
            {
                Console.WriteLine("Please enter a path file");
                return;
            }
            lines = System.IO.File.ReadAllLines(path);
            int totalChars = 0;
            int totalLines = 0;
            int vowels = 0;
            int consonants = 0;
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                totalLines++;
                foreach (char c in line)
                {
                    totalChars++;
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }
            Console.WriteLine("Number of lines: " + totalLines);
            Console.WriteLine("Number of characters: " + totalChars);
            Console.WriteLine("Number of vowels: " + vowels);
            Console.WriteLine("Number of consonants: " + consonants);
            Console.ReadLine();
        }
    }
}
