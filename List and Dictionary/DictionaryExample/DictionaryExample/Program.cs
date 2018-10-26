using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictExample = new Dictionary<string, int>();

            dictExample.Add("First", 100);
            dictExample.Add("Second", 200);
            dictExample.Add("Third", 300);

            foreach (var item in dictExample)
            {
                Console.WriteLine(dictExample[item.Key]);
            }
            Console.WriteLine();

            dictExample.Remove("Second");
            foreach (var item in dictExample)
            {
                Console.WriteLine(dictExample[item.Key]);
            }
            Console.WriteLine();

            if(dictExample.ContainsKey("First"))
            {
                Console.WriteLine("It contains key");
            }

            if(dictExample.ContainsValue(300))
            {
                Console.WriteLine("It contains value");
            }

            Console.WriteLine(dictExample.Count);

            foreach (var key in dictExample.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in dictExample.Values)
            {
                Console.WriteLine(value);
            }

            dictExample.Clear();

            Console.ReadKey();
        }
    }
}
