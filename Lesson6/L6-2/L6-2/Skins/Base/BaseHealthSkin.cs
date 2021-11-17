using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using L6_2.DataBase;
using L6_2.Skins.Base;

namespace L6_2.Skins.Base
{
    public class BaseHealthSkin : IHealthSkin
    {
        public int SkinHealthValue { get; set; }
        public BaseHealthSkin()
        {
            var dbConnection = new DBase(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SkinHealthValue = dbConnection.ReadData(this.GetType().Name).Value;
        }
    }
}