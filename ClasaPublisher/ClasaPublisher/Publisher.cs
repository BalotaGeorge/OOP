using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaPublisher
{
    public delegate void iteratie(int data);
    public class Publisher
    {
        public event iteratie eveniment;
        public void DeclanseazaEveniment(int data)
        {
            for (int i = 0; i < 5; i++)
            {
                eveniment?.Invoke(data);
            }
        }
    }
}
