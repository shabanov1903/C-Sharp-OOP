using System;
using L4_2.Building;
using L4_2.Creator;

namespace L4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatorClass.CreateBuild(30.0f, 10, 100, 2);
            CreatorClass.CreateBuild(40.0f, 12, 60, 6);
            CreatorClass.CreateBuild(70.0f, 18, 80, 3);
            CreatorClass.CreateBuild(90.0f, 26, 95, 8);

            // Печать параметров всех созданных зданий
            foreach (BuildingClass building in CreatorClass.buildings)
            {
                BuildingsPrinter.Print(building);
            }
        }
    }
}