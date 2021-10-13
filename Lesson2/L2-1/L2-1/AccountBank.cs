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
        private long check;
        private decimal balance;
        private CheckType checkType;

        public long GetCheck() => check;
        public void SetCheck()
        {
            checkCounter++;
            check = checkCounter;
        }
        public decimal GetBalance() => balance;
        public void SetBalance(decimal value) => balance = value;
        public CheckType GetCheckType() => checkType;
        public void SetCheckType(CheckType value) => checkType = value;
    }
}