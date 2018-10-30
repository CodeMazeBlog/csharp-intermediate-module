using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    //Declaration
    public delegate void WriterDelegate(string text);
    class Program
    {
        public static void Write(string text)
        {
            Console.WriteLine(text);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //Instantiation
            WriterDelegate writerDelegate = new WriterDelegate(Write);

            //Invocation
            writerDelegate("Some example text.");

            Func<int, int, int> sumDelegate = Sum;
            Console.WriteLine(sumDelegate(10, 20));

            Action<string> writeDelegate = Write;
            writeDelegate("String parameter to write.");
        }
    }
}
