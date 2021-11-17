using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_3.Figures.Base
{
    public class Figure
    {
        private int _color;
        private bool _visible;

        public Figure(int color, bool visible)
        {
            _color = color;
            _visible = visible;
        }

        public float CoordinateX { get; private set; }
        public float CoordinateY { get; private set; }

        public int GetColor() => _color;
        public void SetColor(int value) => _color = value;
        public bool GetVisible() => _visible;
        public bool SetVisible(bool value) => _visible = value;

        public void SetX(float x)
        {
            CoordinateX = x;
        }
        public void SetY(float y)
        {
            CoordinateY = y;
        }

        public override string ToString()
        {
            return new string(
                "Color Code: " + _color.ToString("X") + "\n" +
                "Visible: " + _visible.ToString() + "\n" +
                "Coordinate X: " + CoordinateX.ToString() + "\n" +
                "Coordinate Y: " + CoordinateY.ToString()
                );
        }
    }
}