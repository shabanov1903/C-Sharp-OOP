using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    class AccountBank
    {
        private static long checkCounter = 4000_0000_0000_0000;
        public long check { get; }
        public decimal balance { get; set; }
        public CheckType checkType { get; set; }

        public AccountBank()
        {
            checkCounter++;
            check = checkCounter;
        }
        public AccountBank(CheckType type)
        {
            checkType = type;
            checkCounter++;
            check = checkCounter;
        }
        public AccountBank(decimal bal)
        {
            balance = bal;
            checkCounter++;
            check = checkCounter;
        }
        public AccountBank(CheckType type, decimal bal)
        {
            checkType = type;
            balance = bal;
            checkCounter++;
            check = checkCounter;
        }
    }
}