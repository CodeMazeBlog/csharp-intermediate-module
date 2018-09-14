using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class XMLWriter: Writer
    {
        public XMLWriter(string fileName)
            :base(fileName)
        {
        }

        public void FormatXMLFile()
        {
            Console.WriteLine("Formating XML file");
        }

        public new void SetName()
        {
            Console.WriteLine("Setting name in the XMLWriter class");
        }

        public override void CalculateFileSize()
        {
            base.CalculateFileSize();
            Console.WriteLine("Calculating file size in the XMLWriter class");
        }
    }
}
