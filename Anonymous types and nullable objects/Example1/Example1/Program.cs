using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousObj = new { Name = "nesto", Age = 32 };

            Console.WriteLine($"The name of myAnonymousObject is {myAnonymousObj.Name}, the age is {myAnonymousObj.Age}");

            int? number = null;
            number = 234;//comment this line to print out another result

            if(number.HasValue)
            {
                Console.WriteLine(number.Value);
            }
            else
            {
                Console.WriteLine("number is null");
            }
        }
    }
}
