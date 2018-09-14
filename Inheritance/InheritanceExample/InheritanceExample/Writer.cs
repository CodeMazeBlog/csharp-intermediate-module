using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Writer
    {
        public string FileName { get; set; }

        public Writer(string fileName)
        {
            FileName = fileName;
        }

        public void Write()
        {
            Console.WriteLine("Writing to a file");
        }

        public void SetName()
        {
            Console.WriteLine("Setting name in the base Writer class");
        }

        public virtual void CalculateFileSize()
        {
            Console.WriteLine("Calculating file size in a Writer class");
        }
    }
}
