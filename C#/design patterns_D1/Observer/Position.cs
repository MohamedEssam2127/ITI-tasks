using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Position
    {
        public Position() { }
        public Position(int x, int y, int z) {


            X = x; 
            Y = y;
            Z = z;

        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString()
        {
            return $" ({X},{Y},{Z})";
        }
    }
}
