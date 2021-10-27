using System;

namespace L4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание здания 1
            var building1 = new Building();
            building1.SetHeight(30.0f);
            building1.SetFloors(10);
            building1.SetApartaments(100);
            building1.SetEntrances(2);

            // Создание здания 2
            var building2 = new Building();
            building2.SetHeight(40.0f);
            building2.SetFloors(12);
            building2.SetApartaments(60);
            building2.SetEntrances(3);

            // Печать параметров
            BuildingsPrinter.Print(building1);
            BuildingsPrinter.Print(building2);
        }
    }
}