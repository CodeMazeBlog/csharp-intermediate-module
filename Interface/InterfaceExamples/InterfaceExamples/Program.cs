using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriter xmlWriter = new XmlWriter();
            JsonWriter jsonWriter = new JsonWriter();

            FileWriter fileWriter = new FileWriter(xmlWriter);
            fileWriter.Write();

            fileWriter = new FileWriter(jsonWriter);
            fileWriter.Write();

            Console.ReadKey();
        }
    }
}
