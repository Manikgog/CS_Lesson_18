using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_18
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Z { get; set; }

        public Coordinate() { }
        public Coordinate(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return "X - " + X + "; Y - " + Y + "; Z - " + Z;
        }
    }
}
