using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_3.Figures
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

        public override string ToString()
        {
            return new string(
                base.ToString() + "\n" +
                "Radius: " + Radius.ToString()
                );
        }
    }
}
