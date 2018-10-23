using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(Element.First, 174);
            hashTable.Add(Element.Second, "Sixty");
            hashTable.Add(Element.Third, 124.24);

            if (hashTable.ContainsKey(Element.Second))
            {
                Console.WriteLine($"Collection contains key: {Element.Second} and its value is {hashTable[Element.Second]}");
            }

            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine($"Key: {key}, value: {hashTable[key]}");
            }

            hashTable.Clear();
            Console.WriteLine(hashTable.Count);

            Console.WriteLine();

            Hashtable hashTable1 = new Hashtable();
            hashTable1.Add(Element.First, 174);
            hashTable1.Add(Element.Second, "Sixty");
            hashTable1.Add(Element.Third, 124.24);

            hashTable1.Remove(Element.Second);

            foreach (var key in hashTable1.Keys)
            {
                Console.WriteLine($"Key: {key}, value: {hashTable[key]}");
            }
            Console.WriteLine();

            Hashtable hashTable2 = new Hashtable();
            hashTable2.Add(Element.First, 174);
            hashTable2.Add(Element.Second, "Sixty");
            hashTable2.Add(Element.Third, 124.24);

            var keys = hashTable2.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            var values = hashTable2.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
