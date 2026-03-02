using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
     class Point3D (int x  , int y  , int z) :IComparable,ICloneable
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
        public int Z { get; set; } = z;
        public Point3D() : this(0, 0, 0) {
            
         }
        public Point3D (int  x , int y) : this (x, y, 0) { }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

        public static implicit operator string(Point3D p)
        {
            return p.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D p)
            {
                return X == p.X && Y == p.Y && Z == p.Z;
            }
            return false;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Point3D p)
            {
                if (this.X != p.X)
                    return this.X.CompareTo(p.X);

                return this.Y.CompareTo(p.Y);
            }
            return 1;
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }
    }
}
