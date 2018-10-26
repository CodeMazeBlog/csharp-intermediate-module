using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(34);
            numbers.Add(58);
            numbers.Add(69);

            int oneNumber = numbers[1];

            int[] nums = new int[] { 1, 22, 44 };

            numbers.AddRange(nums);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            if(numbers.Contains(34))
            {
                Console.WriteLine("The number 34 exists in a list");
            }

            int index;
            if((index = numbers.IndexOf(58)) != -1)
            {
                Console.WriteLine($"The number 58 is on the index: {index}");
            }
            Console.WriteLine();

            int[] copyArray = new int[6];
            numbers.CopyTo(copyArray);
            foreach (int copyNumber in copyArray)
            {
                Console.WriteLine(copyNumber);
            }
            Console.WriteLine();

            numbers.Remove(69);

            numbers.Clear();

            Console.WriteLine(numbers.Count);

            Console.ReadKey();
        }
    }
}
