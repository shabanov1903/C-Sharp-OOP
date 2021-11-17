using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L6_2.Heroes.Base;
using L6_2.Heroes;
using L6_2.Observe;

namespace L6_2.Master
{
    public class Controller
    {
        public BlockingCollection<Hero> Heroes;
        async public Task StartLogging()
        {
            while (true)
            {
                await Task.Run(() => {
                    foreach (Hero item in Heroes) item.Log($"{item.GetType().Name}: object alive");
                });
                await Task.Delay(5000);
            }
        }
        public Controller()
        {
            Heroes = new BlockingCollection<Hero>();
            Task.Run(() => StartLogging());
        }

        public void deadthHero(Hero hero)
        {
            hero.Log($"Hero {hero.GetType().Name} is Deadth");
            Heroes.TryTake(out hero);
        }
    }
}