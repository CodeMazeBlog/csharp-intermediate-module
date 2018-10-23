using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intCollection = new Queue<int>();

            Queue queueCollection = new Queue();
            queueCollection.Enqueue(54);
            queueCollection.Enqueue("John");
            queueCollection.Enqueue(54.10);

            foreach (var item in queueCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Queue queueCollection1 = new Queue();
            queueCollection1.Enqueue(54);
            queueCollection1.Enqueue("John");
            queueCollection1.Enqueue(54.10);

            int number = Convert.ToInt32(queueCollection1.Dequeue());
            Console.WriteLine($"Removed element is: {number}");
            Console.WriteLine();

            foreach (var item in queueCollection1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Queue queueCollection2 = new Queue();
            queueCollection2.Enqueue(54);
            queueCollection2.Enqueue("John");
            queueCollection2.Enqueue(54.10);
            
            int peekNumber = Convert.ToInt32(queueCollection2.Peek());
            Console.WriteLine($"Returned element is: {number}");
            Console.WriteLine();

            foreach (var item in queueCollection2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            queueCollection2.Clear();
            Console.WriteLine(queueCollection2.Count);

            Console.ReadKey();
        }
    }
}
