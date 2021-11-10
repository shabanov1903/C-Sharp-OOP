using System;
using Xunit;
using L5_1;

namespace L5_1.Tests
{
    public class L5_1_Tests_String
    {
        [Fact]
        public void Test_ToString()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(8, 3);
            RationalNumb numb3 = new(-3, 4);
            RationalNumb numb4 = new(17, -9);


            Assert.Equal("1/2", numb1.ToString());
            Assert.Equal("8/3", numb2.ToString());
            Assert.Equal("-3/4", numb3.ToString());
            Assert.Equal("-17/9", numb4.ToString());
        }
    }
}