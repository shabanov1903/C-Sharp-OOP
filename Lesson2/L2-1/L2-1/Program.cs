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
            AccountBank account1 = new(bal:50000, type:CheckType.Insured);
            // Инициализация счета 2 в банке
            AccountBank account2 = new(bal:88000, type: CheckType.Correspondent);

            // Печать данных
            printer.Print("Данные пользователя 1:");
            printer.Print(account1.check);
            printer.Print(account1.balance);
            printer.Print(account1.checkType);

            printer.Print("Данные пользователя 2:");
            printer.Print(account2.check);
            printer.Print(account2.balance);
            printer.Print(account2.checkType);
        }
    }
}