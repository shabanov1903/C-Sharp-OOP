using System;

namespace L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Внедрние зависимости для возможности быстрого переноса функционала
            IPrint printer = new ConsolePrinter();

            // Инициализация счета в банке
            AccountBank account = new();
            account.SetCheck(4589_3212_4565_8954);
            account.SetBalance(50000);
            account.SetCheckType(CheckType.Insured);

            // Печать данных
            printer.Print("Данные пользователя:");
            printer.Print(account.GetCheck());
            printer.Print(account.GetBalance());
            printer.Print(account.GetCheckType());
        }
    }
}