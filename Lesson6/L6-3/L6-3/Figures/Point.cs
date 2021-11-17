using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L6_3.Figures.Base;

namespace L6_3.Figures
{
    public class Point : Figure
    {
        public Point(int color, bool visible) : base(color, visible)
        { }

        public virtual float GetArea() => 0.0f;

        public override string ToString()
        {
            return new string(
                base.ToString() + "\n" +
                "Area: " + GetArea().ToString()
                );
        }
    }
}