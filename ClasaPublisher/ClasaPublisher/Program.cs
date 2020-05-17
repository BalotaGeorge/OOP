using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaPublisher
{
    class Program
    {
        static void Handler(int data)
        {
            Console.WriteLine("Eveniment declansat: " + data);
        }

        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            SubscriberA subA = new SubscriberA();
            SubscriberB subB = new SubscriberB();

            publisher.eveniment += Handler;
            publisher.eveniment += subA.HandlerA;
            publisher.eveniment += subB.HandlerB;

            publisher.DeclanseazaEveniment(123);
            Console.ReadLine();
        }

    }
}
