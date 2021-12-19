using System;
using System.Collections.Generic;
using L7_2.Coordinats;
using L7_2.Figures;

namespace L7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров:
            var point = new Point(100, true);
            point.CoordinateX = 10;
            point.CoordinateY = 20;
            var circle = new Circle(150, false, 50);
            circle.CoordinateX = 30;
            circle.CoordinateY = 40;
            var rectangle = new Rectangle(200, true, 10, 20);
            rectangle.CoordinateX = 50;
            rectangle.CoordinateY = 60;

            // Вывод примеров:
            Console.WriteLine("Данные по точке:");
            Console.WriteLine(point.ReturnDescription());
            Console.WriteLine("Данные по кругу:");
            Console.WriteLine(circle.ReturnDescription());
            Console.WriteLine("Данные по прямоугольнику:");
            Console.WriteLine(rectangle.ReturnDescription());

            // Создание листа типа ICoordinator для демонстрации вызова общей функции
            List<ICoordinator> objects = new();
            
            // Заполнение объектами разных типов
            objects.Add(point);
            objects.Add(circle);
            objects.Add(rectangle);

            // Вызов функции GetCoordinats()
            foreach (ICoordinator obj in objects)
            {
                Console.WriteLine($"Координаты объекта {obj.GetType()}:");
                Console.WriteLine(obj.GetCoordinats());
            }
        }
    }
}
