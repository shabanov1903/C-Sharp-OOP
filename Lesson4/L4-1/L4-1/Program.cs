using System;

namespace L4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator.CreateBuild(30.0f, 10, 100, 2);
            Creator.CreateBuild(40.0f, 12, 60, 6);
            Creator.CreateBuild(70.0f, 18, 80, 3);
            Creator.CreateBuild(90.0f, 26, 95, 8);

            // Печать параметров всех созданных зданий
            foreach (Building building in Creator.buildings)
            {
                BuildingsPrinter.Print(building);
            }

            // Удаление элемента с номером 2
            Creator.RemoveAtNumber(2);

            // Печать параметров созданных зданий
            // Ожидание: удалился элемент 2
            foreach (Building building in Creator.buildings)
            {
                BuildingsPrinter.Print(building);
            }
        }
    }
}