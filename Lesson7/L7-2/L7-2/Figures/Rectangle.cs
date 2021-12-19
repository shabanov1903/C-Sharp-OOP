using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_2.Figures
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

        public override string ReturnDescription()
        {
            return new string(
                "Color Code: " + GetColor().ToString("X") + "\n" +
                "Visible: " + GetVisible().ToString() + "\n" +
                "Area: " + GetArea().ToString() + "\n" +
                "Side A: " + SideA.ToString() + "\n" +
                "Side B: " + SideB.ToString()
                );
        }
    }
}