using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaAngajat
{
    public class SomeList<T>
    {
        private readonly List<T> list;
        public T this[int index] { get { return list[index]; } set { list[index] = value; } }
        public SomeList()
        {
            list = new List<T>();
        }
        public void Add(T item)
        {
            list.Add(item);
        }
        public void Remove(T item)
        {
            list.Remove(item);
        }
        public void Sort(Comparison<T> comparison)
        {
            list.Sort(comparison);
        }
    }
}
