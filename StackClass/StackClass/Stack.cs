using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    public class Stack<T>
    {
        public T[] items;
        private int index;
        public int Count { get { return index >= 0 ? index + 1 : 0; } set { index = value; } }

        public Stack(int cantity)
        {
            index = -1;
            items = new T[cantity];
        }

        public void Push(T item)
        {
            if (index + 1 >= items.Length)
            {
                Console.WriteLine("The Stack is full, can't add anymore items");
            }
            else
            {
                index++;
                items[index] = item;
            }
        }

        public T Pop()
        {
            if (index < 0)
            {
                Console.WriteLine("There are no more items to pop out of the Stack");
                return default;
            }
            T value = items[index];
            items[index] = default;
            index--;
            return value;
        }

        public void Clear()
        {
            index = 0;
            items = new T[items.Length];
        }
    }
}
