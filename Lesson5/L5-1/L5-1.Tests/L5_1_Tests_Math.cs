using System;
using Xunit;
using L5_1;

namespace L5_1.Tests
{
    public class L5_1_Tests_Math
    {
        [Fact]
        public void Test_Summa()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 3);

            var answer = new RationalNumb(5, 6);
            var result = numb1 + numb2;

            Assert.Equal<(int, int)>((answer.Numer, answer.Denom), (result.Numer, result.Denom));
        }

        [Fact]
        public void Test_Difference()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 3);

            var answer = new RationalNumb(1, 6);
            var result = numb1 - numb2;

            Assert.Equal<(int, int)>((answer.Numer, answer.Denom), (result.Numer, result.Denom));
        }

        [Fact]
        public void Test_Increment()
        {
            RationalNumb numb1 = new(1, 3);

            var answer = new RationalNumb(4, 3);
            numb1++;

            Assert.Equal<(int, int)>((answer.Numer, answer.Denom), (numb1.Numer, numb1.Denom));
        }

        [Fact]
        public void Test_Decrement()
        {
            RationalNumb numb1 = new(1, 3);

            var answer = new RationalNumb(-2, 3);
            numb1--;

            Assert.Equal<(int, int)>((answer.Numer, answer.Denom), (numb1.Numer, numb1.Denom));
        }

        [Fact]
        public void Test_Multiplication()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 3);

            var answer = new RationalNumb(1, 6);
            var result = numb1 * numb2;

            Assert.Equal<(int, int)>((answer.Numer, answer.Denom), (result.Numer, result.Denom));
        }

        [Fact]
        public void Test_Division()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 3);

            var answer = new RationalNumb(3, 2);
            var result = numb1 / numb2;

            Assert.Equal<(int, int)>((answer.Numer, answer.Denom), (result.Numer, result.Denom));
        }

        [Fact]
        public void Test_RemainderOfDivision()
        {
            RationalNumb numb1 = new(1, 2);
            RationalNumb numb2 = new(1, 3);

            var answer = new RationalNumb(1, 2);
            var result = numb1 % numb2;

            Assert.Equal<(int, int)>((answer.Numer, answer.Denom), (result.Numer, result.Denom));
        }
    }
}