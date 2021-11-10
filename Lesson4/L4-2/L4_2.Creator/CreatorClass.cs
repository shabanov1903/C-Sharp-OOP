using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L4_2.Building;

namespace L4_2.Creator
{
    public static class CreatorClass
    {
        // Hash-коллекция создаваемых зданий
        public static HashSet<BuildingClass> buildings = new();

        // Функция создания объекта здания
        public static void CreateBuild(float height, int floors, int aparts, int entrances)
        {
            var building = new BuildingClass();
            building.SetHeight(height);
            building.SetFloors(floors);
            building.SetApartaments(aparts);
            building.SetEntrances(entrances);
            buildings.Add(building);
        }

        // Удаление объекта здания по его уникальному номеру
        public static void RemoveAtNumber(int number)
        {
            buildings.RemoveWhere(parameter => parameter.GetNumber() == number);
        }

        // Возврат объекта здания по его уникальному номеру
        public static BuildingClass GetByNumber(int number)
        {
            var query = buildings.Where(building => building.GetNumber() == number);
            return query.First();
        }
    }
}