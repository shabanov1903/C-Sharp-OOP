using System;
using Xunit;
using L5_1;

namespace L5_1.Tests
{
    public class L5_1_Tests_Logic
    {
        [Fact]
        public void Test_Equals()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 2);
            RationalNumb numb3 = new(1, 3);

            Assert.True(numb1 == numb2);
            Assert.False(numb1 == numb3);
        }

        [Fact]
        public void Test_Not_Equals()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 3);
            RationalNumb numb3 = new(1, 2);

            Assert.True(numb1 != numb2);
            Assert.False(numb1 != numb3);
        }

        [Fact]
        public void Test_More()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 2);
            RationalNumb numb3 = new(-1, 2);
            RationalNumb numb5 = new(1, 3);
            RationalNumb numb7 = new(-1, 3);
            RationalNumb numb8 = new(-1, 3);

            Assert.True(numb1 > numb5);
            Assert.True(numb7 > numb3);
            Assert.True(numb1 > numb7);

            Assert.False(numb1 < numb5);
            Assert.False(numb7 < numb3);
            Assert.False(numb1 < numb7);

            Assert.False(numb1 > numb2);
            Assert.False(numb7 > numb8);
        }

        [Fact]
        public void Test_Smaller()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 2);
            RationalNumb numb3 = new(-1, 2);
            RationalNumb numb5 = new(1, 3);
            RationalNumb numb7 = new(-1, 3);
            RationalNumb numb8 = new(-1, 3);

            Assert.True(numb5 < numb1);
            Assert.True(numb3 < numb7);
            Assert.True(numb7 < numb1);

            Assert.False(numb5 > numb1);
            Assert.False(numb3 > numb7);
            Assert.False(numb7 > numb1);

            Assert.False(numb1 < numb2);
            Assert.False(numb7 < numb8);
        }

        [Fact]
        public void Test_More_Or_Equal()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 2);
            RationalNumb numb3 = new(-1, 2);
            RationalNumb numb5 = new(1, 3);
            RationalNumb numb7 = new(-1, 3);
            RationalNumb numb8 = new(-1, 3);

            Assert.True(numb1 >= numb5);
            Assert.True(numb7 >= numb3);
            Assert.True(numb1 >= numb7);

            Assert.False(numb1 <= numb5);
            Assert.False(numb7 <= numb3);
            Assert.False(numb1 <= numb7);

            Assert.True(numb1 >= numb2);
            Assert.True(numb7 >= numb8);
        }

        [Fact]
        public void Test_Smaller_Or_Equal()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 2);
            RationalNumb numb3 = new(-1, 2);
            RationalNumb numb5 = new(1, 3);
            RationalNumb numb7 = new(-1, 3);
            RationalNumb numb8 = new(-1, 3);

            Assert.True(numb5 <= numb1);
            Assert.True(numb3 <= numb7);
            Assert.True(numb7 <= numb1);

            Assert.False(numb5 >= numb1);
            Assert.False(numb3 >= numb7);
            Assert.False(numb7 >= numb1);

            Assert.True(numb1 <= numb2);
            Assert.True(numb7 <= numb8);
        }
    }
}