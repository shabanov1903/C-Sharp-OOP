using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_2.Coordinats
{
    public interface ICoordinator
    {
        public float CoordinateX { get; set; }
        public float CoordinateY { get; set; }
        public string GetCoordinats();
    }
}