using System;
using Xunit;
using L6_1;

namespace L6_1.Tests
{
    public class L6_1_Tests_Logic
    {
        [Fact]
        public void Test_Equal()
        {
            // Инициализация счета 1 в банке
            AccountBank account1 = new(bal: 50000, type: CheckType.Insured);

            // Инициализация счета 2 в банке
            AccountBank account2 = new(bal: 50000, type: CheckType.Correspondent);

            // Инициализация счета 3 в банке
            AccountBank account3 = new(bal: 10000, type: CheckType.Insured);

            // Инициализация счета 4 в банке
            AccountBank account4 = new(bal: 50000, type: CheckType.Insured);

            Assert.False(account1 == account2);
            Assert.False(account1 == account3);
            Assert.True(account1 == account4);
        }

        [Fact]
        public void Test_Not_Equal()
        {
            // Инициализация счета 1 в банке
            AccountBank account1 = new(bal: 50000, type: CheckType.Insured);

            // Инициализация счета 2 в банке
            AccountBank account2 = new(bal: 50000, type: CheckType.Correspondent);

            // Инициализация счета 3 в банке
            AccountBank account3 = new(bal: 10000, type: CheckType.Insured);

            // Инициализация счета 4 в банке
            AccountBank account4 = new(bal: 50000, type: CheckType.Insured);

            Assert.True(account1 != account2);
            Assert.True(account1 != account3);
            Assert.False(account1 != account4);
        }
    }
}
