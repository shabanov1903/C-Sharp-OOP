using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_3.Figures
{
    public class Rectangle : Point
    {
        public float SideA { get; set; }
        public float SideB { get; set; }

        public Rectangle(int color, bool visible, float sideA, float sideB) : base(color, visible)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override float GetArea()
        {
            return SideA * SideB;
        }

        public override string ToString()
        {
            return new string(
                base.ToString() + "\n" +
                "Side A: " + SideA.ToString() + "\n" +
                "Side B: " + SideB.ToString()
                );
        }
    }
}
