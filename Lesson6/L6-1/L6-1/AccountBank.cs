using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_1
{
    public class AccountBank
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
        public void Transaction(AccountBank takeAccount, decimal value)
        {
            if (takeAccount.DownBalance(value)) UpBalance(value);
        }

        // Решение задачи 1 урока 6
        // Переопределение операторов
        // Равно:
        public static bool operator == (AccountBank account1, AccountBank account2)
        {
            if ((account1.balance == account2.balance) && (account1.checkType == account2.checkType)) return true;
            else return false;
        }
        // Не Равно:
        public static bool operator != (AccountBank account1, AccountBank account2)
        {
            if ((account1.balance != account2.balance) || (account1.checkType != account2.checkType)) return true;
            else return false;
        }

        public override string ToString()
        {
            return new string(
                "Account number: " + check.ToString() + "\n" +
                "Balance: " + balance + "\n" +
                "Type: " + checkType.ToString()
                );
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}