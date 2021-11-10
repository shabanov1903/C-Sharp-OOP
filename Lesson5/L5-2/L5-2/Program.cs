using System;

namespace L5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходные значения:");
            var numb1 = new ComplexNumb(1, 2);
            var numb2 = new ComplexNumb(1, 3);
            Console.WriteLine(numb1.ToString());
            Console.WriteLine(numb2.ToString());

            Console.WriteLine("Сумма значений:");
            var numbResult = numb1 + numb2;
            Console.WriteLine(numbResult.ToString());

            Console.WriteLine("Разность значений:");
            numbResult = numb1 - numb2;
            Console.WriteLine(numbResult.ToString());

            Console.WriteLine("Произведение значений:");
            numbResult = numb1 * numb2;
            Console.WriteLine(numbResult.ToString());

            Console.WriteLine("Произведение первого числа на 2:");
            numbResult = numb1 * new ComplexNumb(2, 0);
            Console.WriteLine(numbResult.ToString());
        }
    }
}
