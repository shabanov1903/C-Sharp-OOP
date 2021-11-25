using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_1.Coding
{
    public interface ICoder
    {
        public string Encode(string value);
        public string Decode(string value);
    }
}