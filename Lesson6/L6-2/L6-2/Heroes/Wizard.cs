using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using L6_2.Heroes.Base;

namespace L6_2.Heroes
{
    public class Wizard : Hero
    {
        public Wizard(int health, int damage, ILogger logger) : base (health, damage, logger)
        {
            Log("Creating Wizard");
        }
    }
}
