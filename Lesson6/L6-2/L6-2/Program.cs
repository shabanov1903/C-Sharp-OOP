using System;
using L6_2.Master;
using L6_2.Heroes.Base;
using L6_2.Heroes;
using L6_2.Skins;
using NLog;

namespace L6_2
{
    class Program
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        private static Controller controller = new Controller();
        static void Main(string[] args)
        {
            // Создание объектов персонажей
            Hero paladin = new Paladin(100, 10, logger)
                                   .UseDamageSkin(new Water())
                                   .UseHealthSkin(new Pill())
                                   .UseController(controller);
            Hero druid = new Druid(120, 5, logger)
                                   .UseDamageSkin(new Fire())
                                   .UseHealthSkin(new Tablet())
                                   .UseController(controller);
            Hero wizard = new Paladin(70, 15, logger)
                                   .UseDamageSkin(new Wind())
                                   .UseHealthSkin(new Medicine())
                                   .UseController(controller);

            // Паладин атакует Друида, Друид - Волшебника, Волшебник - Паладина. Все атаки пишутся в Лог
            // ReadLine необходим для возможности проверки периодического логгирования объектов
            while (true)
            {
                paladin.Blow(druid);
                druid.Blow(wizard);
                wizard.Blow(paladin);
                Console.Clear();
                Console.WriteLine("Для выхода введите Quit");
                if (Console.ReadLine() == "Quit") break;
            }
        }
    }
}