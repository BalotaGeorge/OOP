using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i; 
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if (l < n && arr[l] > arr[largest])
                largest = l;
            if (r < n && arr[r] > arr[largest])
                largest = r;
            if (largest != i)
            {
                int t = arr[i];
                arr[i] = arr[largest];
                arr[largest] = t;
                Heapify(arr, n, largest);
            }
        }

        static void HeapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);
            for (int i = n - 1; i > 0; i--)
            {
                int t = arr[0];
                arr[0] = arr[i];
                arr[i] = t;
                Heapify(arr, i, 0);
            }
        }

        static void PrintArray(int[] arr, int n)
        {
            Console.WriteLine();
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[] v = new int[rnd.Next(10, 50)];
            for (int i = 0; i < v.Length; i++)
                v[i] = rnd.Next(100);
            PrintArray(v, v.Length);
            HeapSort(v, v.Length);
            PrintArray(v, v.Length);
            Console.ReadLine();
        }
    }
}
