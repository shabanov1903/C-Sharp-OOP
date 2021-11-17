using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L6_2.Skins.Base;
using L6_2.Observe;
using L6_2.Master;
using NLog;

namespace L6_2.Heroes.Base
{
    public delegate void Deadth(Hero hero);

    public abstract class Hero : IHeroAction, IObserve
    {
        public int Health { get; private set; }
        public int Damage { get; private set; }
        private readonly ILogger _logger;
        public event Deadth death;

        public Hero(int health, int damage, ILogger logger)
        {
            Health = health;
            Damage = damage;
            _logger = logger;
        }

        public void SetHealth(int value) => Health += value;
        public void SetDamage(int value) => Damage += value;
        public void Blow(Hero hero)
        {
            if (hero.Health <= 0) return;
            hero.Log($"{hero.GetType().ToString()} is attacked");
            hero.SetHealth(-Damage);
            if (hero.Health <= 0) death(hero);
        }

        public Hero UseDamageSkin(IDamageSkin skin)
        {
            Damage += skin.SkinDamageValue;
            return this;
        }

        public Hero UseHealthSkin(IHealthSkin skin)
        {
            Health += skin.SkinHealthValue;
            return this;
        }

        public Hero UseController(Controller controller)
        {
            controller.Heroes.Add(this);
            death += controller.deadthHero;
            return this;
        }

        public void Log(string message)
        {
            _logger.Debug("Hero: " + message);
        }
    }
}