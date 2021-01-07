using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Com_14Template
{
    public class TextFile : DataProcessor
    {
       
        public override void ReadData()
        {
            Console.WriteLine("Reads data from Text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from Text file");
        }

    }
}
