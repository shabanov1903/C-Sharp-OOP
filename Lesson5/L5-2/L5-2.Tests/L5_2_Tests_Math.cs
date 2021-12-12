using System;
using Xunit;
using L5_2;

namespace L5_2.Tests
{
    public class L5_2_Tests_Math
    {
        [Fact]
        public void Test_Summa()
        {
            ComplexNumb numb1 = new(1, 2);
            ComplexNumb numb2 = new(1, 3);

            var answer = new ComplexNumb(2, 5);
            var result = numb1 + numb2;

            Assert.Equal<(int, int)>((answer.Real, answer.Imag), (result.Real, result.Imag));
        }

        [Fact]
        public void Test_Difference()
        {
            ComplexNumb numb1 = new(1, 2);
            ComplexNumb numb2 = new(1, 3);

            var answer = new ComplexNumb(0, -1);
            var result = numb1 - numb2;

            Assert.Equal<(int, int)>((answer.Real, answer.Imag), (result.Real, result.Imag));
        }

        [Fact]
        public void Test_Multiplication()
        {
            ComplexNumb numb1 = new(1, 2);
            ComplexNumb numb2 = new(1, 3);

            var answer = new ComplexNumb(-5, 5);
            var result = numb1 * numb2;

            Assert.Equal<(int, int)>((answer.Real, answer.Imag), (result.Real, result.Imag));
        }
    }
}