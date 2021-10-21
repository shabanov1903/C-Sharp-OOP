using System;

namespace L3_1
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
            AccountBank account2 = new(bal:100000, type: CheckType.Correspondent);

            // Транзакция 1:
            account1.Transaction(account2, 50000);

            // Печать данных (ожидаем положительную транзанкцию, т.к. на счёте account2 было 100000)
            printer.Print("Результат транзакции 1:");
            printer.Print("Данные пользователя 1:");
            printer.Print(account1.check);
            printer.Print(account1.balance);
            printer.Print(account1.checkType);

            printer.Print("Данные пользователя 2:");
            printer.Print(account2.check);
            printer.Print(account2.balance);
            printer.Print(account2.checkType);
            printer.Print("");

            // Транзакция 2:
            account1.Transaction(account2, 70000);

            // Печать данных (ожидаем отрицательную транзанкцию, т.к. на счёте account2 было 50000)
            printer.Print("Результат транзакции 2:");
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