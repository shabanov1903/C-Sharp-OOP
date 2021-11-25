using System;
using L7_1.Coding;

namespace L7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var codera = new CoderA();
            var coderb = new CoderB();
            Console.WriteLine("Введите любую строку:");
            string input = Console.ReadLine();
            Console.WriteLine("Результат шифрования методом 1:");
            Console.WriteLine(codera.Encode(input));
            Console.WriteLine("Результат шифрования методом 2:");
            Console.WriteLine(coderb.Encode(input));
            Console.WriteLine("Результат дешифрования методом 1:");
            Console.WriteLine(codera.Decode(codera.Encode(input)));
            Console.WriteLine("Результат дешифрования методом 2:");
            Console.WriteLine(coderb.Decode(coderb.Encode(input)));
        }
    }
}