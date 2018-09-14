using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLWriter xmlWriter = new XMLWriter("xmlFileName");
            xmlWriter.FormatXMLFile();
            xmlWriter.Write();
            Console.WriteLine(xmlWriter.FileName);

            JSONWriter jsonWriter = new JSONWriter("jsonFileName");
            jsonWriter.FormatJSONFile();
            jsonWriter.Write();
            Console.WriteLine(jsonWriter.FileName);

            
            XMLWriter xml = new XMLWriter("any name");
            Writer writer = xml; //writer points to xml

            XMLWriter newWriter = writer as XMLWriter; //this is ok now because writer was xml
            newWriter.FormatXMLFile();
            
        }
    }
}
