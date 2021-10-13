using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    class AccountBank
    {
        private long check;
        private decimal balance;
        private CheckType checkType;

        public long GetCheck() => check;
        public void SetCheck(long value) => check = value;
        public decimal GetBalance() => balance;
        public void SetBalance(decimal value) => balance = value;
        public CheckType GetCheckType() => checkType;
        public void SetCheckType(CheckType value) => checkType = value;
    }
}