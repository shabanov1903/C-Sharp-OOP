using System;
using Xunit;
using L5_2;

namespace L5_2.Tests
{
    public class L5_2_Tests_Logic
    {
        [Fact]
        public void Test_Equal()
        {
            ComplexNumb numb1 = new(1, 2);
            ComplexNumb numb2 = new(1, 2);

            Assert.True(numb1 == numb2);
        }

        [Fact]
        public void Test_Not_Equal()
        {
            ComplexNumb numb1 = new(1, 2);
            ComplexNumb numb2 = new(1, 3);

            Assert.True(numb1 != numb2);
        }
    }
}
