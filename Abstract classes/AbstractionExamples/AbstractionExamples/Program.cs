using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExamples
{
    public class AbstractExampleClass
    {
        public void PrintToConsole(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractExampleClass example = new AbstractExampleClass();
        }
    }
}
