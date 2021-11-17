using System;
using Xunit;
using L6_3.Figures;

namespace L6_3.Tests
{
    public class L6_3_Tests_Math
    {
        [Fact]
        public void Test_Point()
        {
            var point = new Point(100, true);
            point.SetX(10);
            point.SetY(20);

            Assert.True(point.CoordinateX == 10);
            Assert.True(point.CoordinateY == 20);
            Assert.True(point.GetArea() == 0.0f);
        }

        [Fact]
        public void Test_Circle()
        {
            var circle = new Circle(100, true, 10);
            circle.SetX(10);
            circle.SetY(20);

            Assert.True(circle.CoordinateX == 10);
            Assert.True(circle.CoordinateY == 20);
            Assert.True(circle.GetArea() == (float)Math.PI*10*10);
        }

        [Fact]
        public void Test_Rectangle()
        {
            var rectangle = new Rectangle(100, true, 10, 20);
            rectangle.SetX(10);
            rectangle.SetY(20);

            Assert.True(rectangle.CoordinateX == 10);
            Assert.True(rectangle.CoordinateY == 20);
            Assert.True(rectangle.GetArea() == 10 * 20);
        }
    }
}