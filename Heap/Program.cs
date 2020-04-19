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
            var rnd = new Random();

            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(rnd.Next(1, 100));
            }

            var heap = new Heap<int>(list);

            foreach (var item in heap.items)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine(heap.Peek());

            heap.Pop();
            foreach (var item in heap.items)
            {
                Console.Write(item + ", ");
            }

            Console.ReadLine();
        }
    }
}
