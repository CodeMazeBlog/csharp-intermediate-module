using System;

namespace ActionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, string> func = Display;
            func("Ahmad", "Sadegh");
            Console.ReadLine();           
        }
        static void Display(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"{fullName}");
        }
        
    }
}

