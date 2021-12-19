using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_1.Coding
{
    public class CoderA : ICoder
    {
        public string Encode(string value)
        {
            var output = new StringBuilder();
            foreach(char ch in value)
            {
                output.Append(CodeCharacter(ch));
            }
            return output.ToString();
        }

        public string Decode(string value)
        {
            var output = new StringBuilder();
            foreach (char ch in value)
            {
                output.Append(DeCodeCharacter(ch));
            }
            return output.ToString();
        }

        private char CodeCharacter(char val)
        {
            if ((((int)val >= 65) && ((int)val <= 90)) ||
                (((int)val >= 97) && ((int)val <= 122)) ||
                (((int)val >= 1040) && ((int)val <= 1103))
                )
            {
                if (val == 'z') return 'a';
                if (val == 'Z') return 'A';
                if (val == 'я') return 'а';
                if (val == 'Я') return 'А';
                return (char)((int)val + 1);
            }
            else return val;
        }

        private char DeCodeCharacter(char val)
        {
            if ((((int)val >= 65) && ((int)val <= 90)) ||
                (((int)val >= 97) && ((int)val <= 122)) ||
                (((int)val >= 1040) && ((int)val <= 1103))
                )
            {
                if (val == 'a') return 'z';
                if (val == 'A') return 'Z';
                if (val == 'а') return 'я';
                if (val == 'А') return 'Я';
                return (char)((int)val - 1);
            }
            else return val;
        }
    }
}