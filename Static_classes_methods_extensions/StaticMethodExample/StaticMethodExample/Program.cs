using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string word = "football".FirstLetterUpperCase();

            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
