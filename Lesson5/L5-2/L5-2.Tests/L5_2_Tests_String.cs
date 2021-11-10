using System;
using Xunit;
using L5_2;

namespace L5_2.Tests
{
    public class L5_2_Tests_String
    {
        [Fact]
        public void Test_ToString()
        {
            ComplexNumb numb1 = new(1, 2);
            ComplexNumb numb2 = new(2, 10);
            ComplexNumb numb3 = new(-6, 22);
            ComplexNumb numb4 = new(-8, 54);

            Assert.Equal("1 + j(2)", numb1.ToString());
            Assert.Equal("2 + j(10)", numb2.ToString());
            Assert.Equal("-6 + j(22)", numb3.ToString());
            Assert.Equal("-8 + j(54)", numb4.ToString());
        }
    }
}