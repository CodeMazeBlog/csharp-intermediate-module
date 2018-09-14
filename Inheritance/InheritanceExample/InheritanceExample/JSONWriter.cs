using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class JSONWriter: Writer
    {
        public JSONWriter(string fileName)
            : base(fileName)
        {
        }

        public void FormatJSONFile()
        {
            Console.WriteLine("Formating JSON file");
        }

        public new void SetName()
        {
            Console.WriteLine("Setting name in the JSONWriter class");
        }

        public override void CalculateFileSize()
        {
            Console.WriteLine("Calculating file size in the JSONWriter class");
        }
    }
}
