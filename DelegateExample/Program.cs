using System;
using System.IO;

namespace DelegateExample
{
    internal class Program
    {
        private const string Path = "d:\\message.txt";
        static FileStream fs;
        static StreamWriter sw;

        // delegate declaration
        public delegate void printString(string s);

        // this method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        //this method prints to a file
        public static void WriteToFile(string s)
        {
            fs = new FileStream(Path,
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        // this method takes the delegate as a parameter and uses it to
        // call the methods as required
        public static void sendString(printString ps)
        {
            // delegate invocation
            ps("Hello World");
        }

        static void Main(string[] args)
        {
            // delegate instantiation
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }
    }
}
