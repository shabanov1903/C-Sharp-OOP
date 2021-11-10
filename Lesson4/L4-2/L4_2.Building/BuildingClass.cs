using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_2.Building
{
    public class BuildingClass
    {
        // Общий статический счетчик
        private static int counter;

        // Уникальный номер строения
        private int number;
        // Высота здания
        private float height;
        // Количество этажей
        private int floors;
        // Количество квартир
        private int apartaments;
        // Количество подъездов
        private int entrances;

        // Конструктор
        public BuildingClass()
        {
            counter++;
            number = counter;
        }

        // Функции чтения полей
        public int GetNumber() => number;
        public float GetHeight() => height;
        public int GetFloors() => floors;
        public int GetApartaments() => apartaments;
        public int GetEntrances() => entrances;

        // Функции записи полей
        // public void SetNumber(int value) => number = value;
        public void SetHeight(float value) => height = value;
        public void SetFloors(int value) => floors = value;
        public void SetApartaments(int value) => apartaments = value;
        public void SetEntrances(int value) => entrances = value;

        // Расчетные функции
        // Высота этажа
        public float GetHeihgtOfFloor() => height / floors;
        // Количество квартир в подъезде
        public int GetApartamentsOnEntrance() => apartaments / entrances;
        // Количество квартир на этаже
        public int GetApartamentsOnFloor() => apartaments / floors;
    }
}