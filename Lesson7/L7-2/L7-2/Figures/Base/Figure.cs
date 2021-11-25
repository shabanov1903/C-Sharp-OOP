using L7_2.Coordinats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_2.Figures.Base
{
    public abstract class Figure : ICoordinator
    {
        private int _color;
        private bool _visible;

        public Figure(int color, bool visible)
        {
            _color = color;
            _visible = visible;
        }

        public float CoordinateX { get; set; }
        public float CoordinateY { get; set; }

        public string GetCoordinats()
        {
            return new string(
                "X: " + CoordinateX.ToString() + "\n" +
                "Y: " + CoordinateY.ToString()
            );
        }

        public int GetColor() => _color;
        public void SetColor(int value) => _color = value;
        public bool GetVisible() => _visible;
        public bool SetVisible(bool value) => _visible = value;

        public abstract string ReturnDescription();
    }
}