using System;
using L6_3.Figures;

namespace L6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров:
            var point = new Point(100, true);
            point.SetX(10);
            point.SetY(20);
            var circle = new Circle(150, false, 50);
            circle.SetX(30);
            circle.SetY(40);
            var rectangle = new Rectangle(200, true, 10, 20);
            rectangle.SetX(50);
            rectangle.SetY(60);

            // Вывод примеров:
            Console.WriteLine("Данные по точке:");
            Console.WriteLine(point.ToString());
            Console.WriteLine("Данные по кругу:");
            Console.WriteLine(circle.ToString());
            Console.WriteLine("Данные по прямоугольнику:");
            Console.WriteLine(rectangle.ToString());
        }
    }
}