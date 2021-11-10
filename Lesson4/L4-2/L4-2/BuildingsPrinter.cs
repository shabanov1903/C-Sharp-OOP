using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L4_2.Building;

namespace L4_2
{
    internal static class BuildingsPrinter
    {
        public static void Print(BuildingClass building)
        {
            Console.WriteLine("Параметры здания с номером " + building.GetNumber() + ":");
            Console.WriteLine("Высота: " + building.GetHeight() + "м");
            Console.WriteLine("Количество этажей: " + building.GetFloors());
            Console.WriteLine("Количество квартир: " + building.GetApartaments());
            Console.WriteLine("Количество подъездов: " + building.GetEntrances());
            Console.WriteLine("Высота этажа: " + building.GetHeihgtOfFloor() + "м");
            Console.WriteLine("Количество квартир в подъезде: " + building.GetApartamentsOnEntrance());
            Console.WriteLine("Количество квартир на этаже: " + building.GetApartamentsOnFloor());
            Console.WriteLine();
        }
    }
}
