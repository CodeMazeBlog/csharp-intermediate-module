using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Stack<int> stackInt = new Stack<int>();

            Stack stackCollection1 = new Stack();
            stackCollection1.Push(328);
            stackCollection1.Push("Fifty Five");
            stackCollection1.Push(124.87);

            foreach (var item in stackCollection1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Stack stackCollection2 = new Stack();
            stackCollection2.Push(328);
            stackCollection2.Push("Fifty Five");
            stackCollection2.Push(124.87);

            double number = Convert.ToDouble(stackCollection2.Pop());
            Console.WriteLine($"Element removed from a collection is: {number}");

            foreach (var item in stackCollection2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Stack stackCollection3 = new Stack();
            stackCollection3.Push(328);
            stackCollection3.Push("Fifty Five");
            stackCollection3.Push(124.87);

            double number1 = Convert.ToDouble(stackCollection3.Peek());
            Console.WriteLine($"Element returned from a collection is: {number}");

            foreach (var item in stackCollection3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            stackCollection3.Clear();
            Console.WriteLine(stackCollection3.Count);

            Console.ReadKey();
        }
    }
}
