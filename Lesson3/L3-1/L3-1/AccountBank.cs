using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_1
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

        public void UpBalance(decimal val)
        {
            balance += val;
        }
        public bool DownBalance(decimal val)
        {
            if ((balance - val) > 0)
            {
                balance -= val;
                return true;
            }
            return false;
        }

        /*
        Результат решения задачи 1 для урока 3
        Функция, производящая транзакцию со счета на определенную сумму
        */
        public void Transaction(AccountBank takeAccount, decimal value)
        {
            if (takeAccount.DownBalance(value)) UpBalance(value);
        }
    }
}