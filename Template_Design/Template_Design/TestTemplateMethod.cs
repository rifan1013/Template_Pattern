using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Com_14Template
{
    class TestTemplateMethod
    {
       static void Main()
        {
            DataProcessor obj = new ExcelFile();
            obj.ReadProcessandSave();
           // obj.ReadData();
            //obj.ProcessData();
            //obj.SaveData();

            TextFile obj2 = new TextFile();
            obj2.ReadProcessandSave();
            //obj2.ReadData();
            //obj2.ProcessData();
            //obj2.SaveData();
        }
    }
}
