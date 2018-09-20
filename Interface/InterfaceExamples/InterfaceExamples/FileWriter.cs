using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class FileWriter
    {
        private readonly IWriter _writer;

        public FileWriter(IWriter writer)
        {
            _writer = writer;
        }

        public void Write()
        {
            _writer.WriteFile();
        }
    }
}
