using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new Heap<int>();

            heap.Push(20);
            heap.Push(2);
            heap.Push(23);
            heap.Push(5);
            heap.Push(7);
            heap.Push(14);
            heap.Push(8);
            heap.Push(18);
            heap.Push(1);

            foreach (var item in heap.items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(heap.Peek());

            heap.Pop();
            foreach (var item in heap.items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
