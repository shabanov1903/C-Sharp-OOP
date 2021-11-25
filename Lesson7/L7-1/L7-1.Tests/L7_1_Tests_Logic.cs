using System;
using Xunit;
using L7_1.Coding;

namespace L7_1.Tests
{
    public class L7_1_Tests_Logic
    {
        [Fact]
        public void Test1()
        {
            string etalonString = "���� ���� ����, � � ��� ����� � 7 oClock, zzZZ";
            string codeStringA = "���� ���� ����, � � ��� ����� � 7 pDmpdl, aaAA";
            string codeStringB = "���� ���� ����, � � ��� ����� � 7 OcLOCK, ZZzz";

            var codera = new CoderA();
            var coderb = new CoderB();

            Assert.True(codera.Encode(etalonString) == codeStringA);
            Assert.True(coderb.Encode(etalonString) == codeStringB);
            Assert.True(codera.Decode(codeStringA) == etalonString);
            Assert.True(coderb.Decode(codeStringB) == etalonString);
        }
    }
}