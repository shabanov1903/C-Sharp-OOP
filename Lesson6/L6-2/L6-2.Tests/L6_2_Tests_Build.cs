using System;
using L6_2.Master;
using L6_2.Heroes.Base;
using L6_2.Heroes;
using L6_2.Skins;
using Moq;
using NLog;
using Xunit;
using L6_2.Skins.Base;

namespace L6_2.Tests
{
    public class L6_2_Tests_Build
    {
        [Fact]
        public void Test_Objekt_Build()
        {
            var _moq_logger = new Mock<ILogger>();

            var _moq_fire = new Mock<IDamageSkin>();
            var _moq_water = new Mock<IDamageSkin>();
            var _moq_wind = new Mock<IDamageSkin>();
            var _moq_medicine = new Mock<IHealthSkin>();
            var _moq_pill = new Mock<IHealthSkin>();
            var _moq_tablet = new Mock<IHealthSkin>();

            _moq_fire.SetupGet(obj => obj.SkinDamageValue).Returns(20);
            _moq_water.SetupGet(obj => obj.SkinDamageValue).Returns(20);
            _moq_wind.SetupGet(obj => obj.SkinDamageValue).Returns(20);
            _moq_medicine.SetupGet(obj => obj.SkinHealthValue).Returns(20);
            _moq_pill.SetupGet(obj => obj.SkinHealthValue).Returns(20);
            _moq_tablet.SetupGet(obj => obj.SkinHealthValue).Returns(20);

            Controller controller = new Controller();
            Hero paladin = new Paladin(100, 10, _moq_logger.Object)
                                      .UseDamageSkin(_moq_water.Object)
                                      .UseHealthSkin(_moq_pill.Object)
                                      .UseController(controller);

            Hero druid = new Druid(100, 10, _moq_logger.Object)
                                      .UseDamageSkin(_moq_fire.Object)
                                      .UseHealthSkin(_moq_tablet.Object)
                                      .UseController(controller);

            Hero wizard = new Paladin(100, 10, _moq_logger.Object)
                                      .UseDamageSkin(_moq_wind.Object)
                                      .UseHealthSkin(_moq_medicine.Object)
                                      .UseController(controller);

            Assert.True(paladin.Health == (100 + 20));
            Assert.True(paladin.Damage == (10 + 20));
            Assert.True(druid.Health == (100 + 20));
            Assert.True(druid.Damage == (10 + 20));
            Assert.True(wizard.Health == (100 + 20));
            Assert.True(wizard.Damage == (10 + 20));
        }
    }
}