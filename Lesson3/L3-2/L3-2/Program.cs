using System;

namespace L3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string output = ConvertString(input);
            Console.WriteLine("Перевернутая строка:");
            Console.WriteLine(output);
        }

        public static string ConvertString(string str)
        {
            var strLength = str.Length;
            char[] arr = new char[strLength];
            for (int i = 0; i < strLength; i++)
            {
                arr[i] = str[strLength - i - 1];
            }
            return new string(arr);
        }
    }
}
