using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaPublisher
{
    public class SubscriberA
    {
        public void HandlerA(int data)
        {
            Console.WriteLine("Eventimentul declansat a fost primit de A: " + data);
        }
    }
}
