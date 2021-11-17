using System;

namespace L6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация счета 1 в банке
            AccountBank account1 = new(bal: 50000, type: CheckType.Insured);

            // Инициализация счета 2 в банке
            AccountBank account2 = new(bal: 100000, type: CheckType.Correspondent);

            // Инициализация счета 3 в банке
            AccountBank account3 = new(bal: 50000, type: CheckType.Contract);

            // Инициализация счета 4 в банке
            AccountBank account4 = new(bal: 50000, type: CheckType.Insured);

            // Вывод информации по всем счетам
            Console.WriteLine("Счет 1:");
            Console.WriteLine(account1.ToString());
            Console.WriteLine("Счет 2:");
            Console.WriteLine(account2.ToString());
            Console.WriteLine("Счет 3:");
            Console.WriteLine(account3.ToString());
            Console.WriteLine("Счет 4:");
            Console.WriteLine(account4.ToString());

            // Вывод информации сравнения:
            Console.WriteLine("Результат сравнения счета 1 с остальными счетами:");
            Console.WriteLine(account1 == account2);
            Console.WriteLine(account1 == account3);
            Console.WriteLine(account1 == account4);
        }
    }
}