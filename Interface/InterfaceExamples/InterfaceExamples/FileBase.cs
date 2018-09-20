using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class FileBase
    {
        public virtual void SetName()
        {
            Console.WriteLine("Setting name in the base Writer class.");
        }
    }
}
