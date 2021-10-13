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

        public AccountBank()
        {
            SetCheck();
        }
        public AccountBank(CheckType type)
        {
            checkType = type;
            SetCheck();
        }
        public AccountBank(decimal bal)
        {
            balance = bal;
            SetCheck();
        }
        public AccountBank(CheckType type, decimal bal)
        {
            checkType = type;
            balance = bal;
            SetCheck();
        }
        public long GetCheck() => check;
        private void SetCheck()
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