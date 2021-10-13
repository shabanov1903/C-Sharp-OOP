using System;

namespace L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Внедрние зависимости для возможности быстрого переноса функционала
            IPrint printer = new ConsolePrinter();

            // Инициализация счета 1 в банке
            AccountBank account1 = new();
            account1.SetCheck();
            account1.SetBalance(50000);
            account1.SetCheckType(CheckType.Insured);
            AccountBank account2 = new();
            account2.SetCheck();
            account2.SetBalance(88000);
            account2.SetCheckType(CheckType.Correspondent);

            // Печать данных
            printer.Print("Данные пользователя 1:");
            printer.Print(account1.GetCheck());
            printer.Print(account1.GetBalance());
            printer.Print(account1.GetCheckType());

            printer.Print("Данные пользователя 2:");
            printer.Print(account2.GetCheck());
            printer.Print(account2.GetBalance());
            printer.Print(account2.GetCheckType());
        }
    }
}