using System;
using Xunit;
using L7_2.Figures;

namespace L7_2.Tests
{
    public class L7_2_Tests_Math
    {
        [Fact]
        public void Test_Point()
        {
            var point = new Point(100, true);
            point.CoordinateX = 10;
            point.CoordinateY = 20;

            Assert.True(point.GetArea() == 0.0f);
        }

        [Fact]
        public void Test_Circle()
        {
            var circle = new Circle(100, true, 10);
            circle.CoordinateX = 10;
            circle.CoordinateY = 20;

            Assert.True(circle.GetArea() == (float)Math.PI * 10 * 10);
        }

        [Fact]
        public void Test_Rectangle()
        {
            var rectangle = new Rectangle(100, true, 10, 20);
            rectangle.CoordinateX = 10;
            rectangle.CoordinateY = 20;

            Assert.True(rectangle.GetArea() == 10 * 20);
        }
    }
}