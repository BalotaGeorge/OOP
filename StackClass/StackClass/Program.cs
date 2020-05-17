using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ints = new Stack<int>(3);
            ints.Push(4);
            Console.WriteLine(ints.Pop());
            ints.Pop();
            ints.Push(4);
            ints.Push(4);
            ints.Push(4);
            ints.Push(4);

            Console.WriteLine();

            Stack<string> strings = new Stack<string>(2);
            strings.Push("Hey");
            strings.Push("Ya");
            strings.Clear();
            strings.Push("!");
            Console.WriteLine(strings.Pop());
            Console.ReadLine();
        }
    }
}
