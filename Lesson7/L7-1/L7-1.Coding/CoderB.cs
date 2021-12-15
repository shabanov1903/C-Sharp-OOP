using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_1.Coding
{
    public class CoderB : ICoder
    {
        public string Encode(string value)
        {
            var output = new StringBuilder();
            foreach (char ch in value)
            {
                output.Append(InvertCharacter(ch));
            }
            return output.ToString();
        }

        public string Decode(string value)
        {
            var output = new StringBuilder();
            foreach (char ch in value)
            {
                output.Append(InvertCharacter(ch));
            }
            return output.ToString();
        }

        private char InvertCharacter(char val)
        {
            if ((((int)val >= 65) && ((int)val <= 90)))
            {
                return (char)((int)val + 32);
            }
            if ((((int)val >= 97) && ((int)val <= 122)))
            {
                return (char)((int)val - 32);
            }
            if ((((int)val >= 1040) && ((int)val <= 1071)))
            {
                return (char)((int)val + 32);
            }
            if ((((int)val >= 1072) && ((int)val <= 1103)))
            {
                return (char)((int)val - 32);
            }
            else return val;
        }
    }
}
