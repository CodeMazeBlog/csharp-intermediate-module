using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class XmlWriter: FileBase, IWriter, IFormatter
    {
        public void WriteFile()
        {
            Console.WriteLine("Writing file in the XmlWriter class.");
        }

        public override void SetName()
        {
            Console.WriteLine("Setting name in the XmlWriter class.");
        }

        public void FormatFile()
        {
            Console.WriteLine("Formatting file in XmlWriter class.");
        }
    }
}
