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
            // ������������� ����� 1 � �����
            AccountBank account1 = new(bal: 50000, type: CheckType.Insured);

            // ������������� ����� 2 � �����
            AccountBank account2 = new(bal: 50000, type: CheckType.Correspondent);

            // ������������� ����� 3 � �����
            AccountBank account3 = new(bal: 10000, type: CheckType.Insured);

            // ������������� ����� 4 � �����
            AccountBank account4 = new(bal: 50000, type: CheckType.Insured);

            Assert.False(account1 == account2);
            Assert.False(account1 == account3);
            Assert.True(account1 == account4);
        }

        [Fact]
        public void Test_Not_Equal()
        {
            // ������������� ����� 1 � �����
            AccountBank account1 = new(bal: 50000, type: CheckType.Insured);

            // ������������� ����� 2 � �����
            AccountBank account2 = new(bal: 50000, type: CheckType.Correspondent);

            // ������������� ����� 3 � �����
            AccountBank account3 = new(bal: 10000, type: CheckType.Insured);

            // ������������� ����� 4 � �����
            AccountBank account4 = new(bal: 50000, type: CheckType.Insured);

            Assert.True(account1 != account2);
            Assert.True(account1 != account3);
            Assert.False(account1 != account4);
        }
    }
}
