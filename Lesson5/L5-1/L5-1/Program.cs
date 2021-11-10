using System;

namespace L5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходные значения:");
            var numb1 = new RationalNumb(1, 2);
            var numb2 = new RationalNumb(1, 3);
            Console.WriteLine(numb1.ToString());
            Console.WriteLine(numb2.ToString());

            Console.WriteLine("Инкременты:");
            numb1++;
            numb2++;
            Console.WriteLine(numb1.ToString());
            Console.WriteLine(numb2.ToString());

            Console.WriteLine("Сумма инкрементированных значений:");
            var numbResult = numb1 + numb2;
            Console.WriteLine(numbResult.ToString());

            Console.WriteLine("Произведение результата на 2:");
            numbResult = numbResult * new RationalNumb(2, 1);
            Console.WriteLine(numbResult.ToString());
        }
    }
}
