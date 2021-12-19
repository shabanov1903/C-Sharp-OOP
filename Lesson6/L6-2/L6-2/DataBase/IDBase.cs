using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L6_2.Skins.Base;

namespace L6_2.DataBase
{
    public interface IDBase
    {
        public SkinObject ReadData(string name);
    }
}