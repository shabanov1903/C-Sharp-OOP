using System;
using System.IO;
using System.Text.RegularExpressions;

namespace L3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу:");
            string input = Console.ReadLine();

            // Чтения файла и запись в файл в том же каталоге в пометкой "_Result"
            using (var stream = new StreamReader(input))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    FindMail(ref line);
                    using (var streamWriter = new StreamWriter(input.Replace(".", "_Result."), true))
                    {
                        streamWriter.WriteLine(line);
                    }
                }
            }
        }

        // Функция, преодбразующая ФИО&Почта -> Почта
        public static void FindMail(ref string mail)
        {
            var patternMail = @"(?<=&).*";
            Regex regexMail = new Regex(patternMail);
            mail = regexMail.Match(mail).Value;
        }
    }
}