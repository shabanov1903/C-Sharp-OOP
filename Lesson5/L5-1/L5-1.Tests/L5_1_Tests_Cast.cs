using System;
using Xunit;
using L5_1;

namespace L5_1.Tests
{
    public class L5_1_Tests_Cast
    {
        [Fact]
        public void Test_Cast()
        {
            RationalNumb numb1 = new(1, 2);

            Assert.IsAssignableFrom<float>((float)numb1);
            Assert.IsAssignableFrom<int>((int)numb1);
        }
    }
}