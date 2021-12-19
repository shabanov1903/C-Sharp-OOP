using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L7_2.Figures.Base;

namespace L7_2.Figures
{
    public class Point : Figure
    {
        public Point(int color, bool visible) : base(color, visible)
        { }

        public virtual float GetArea() => 0.0f;

        public override string ReturnDescription()
        {
            return new string(
                "Color Code: " + GetColor().ToString("X") + "\n" +
                "Visible: " + GetVisible().ToString() + "\n" +
                "Area: " + GetArea().ToString()
                );
        }
    }
}