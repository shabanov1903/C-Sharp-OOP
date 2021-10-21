using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    class ConsolePrinter : IPrint
    {
        public void Print(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}