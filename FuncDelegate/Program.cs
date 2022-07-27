using System;

namespace FuncDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> func = Display;
            string fullName = func("Ahmad", "Sadegh");
            Console.WriteLine(fullName);
            Console.ReadLine();
        }
        static string Display(string firstName, string lastName)
        {
            return firstName + ' ' + lastName;
        }
    }
}
