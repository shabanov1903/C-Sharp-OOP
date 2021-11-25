using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_2.Figures
{
    public class Circle : Point
    {
        public float Radius { get; set; }

        public Circle(int color, bool visible, float radius) : base(color, visible)
        {
            Radius = radius;
        }

        public override float GetArea()
        {
            return (float)Math.PI * Radius * Radius;
        }

        public override string ReturnDescription()
        {
            return new string(
                "Color Code: " + GetColor().ToString("X") + "\n" +
                "Visible: " + GetVisible().ToString() + "\n" +
                "Area: " + GetArea().ToString() + "\n" +
                "Radius: " + Radius.ToString()
                );
        }
    }
}