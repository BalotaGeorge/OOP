using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c1 = new Card(CardRank.SEVEN, CardSuit.DIAMOND);
            Console.WriteLine(c1);
            Console.ReadLine();
        }
    }
}
