using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    class ThreeDPoint:IComparable,ICloneable
    {
        #region(1) Define 3D Point Class and the basic Constructors (use chaining in constructors).
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public ThreeDPoint():this (0,0,0)
        {
        }

        public ThreeDPoint (double X, double Y):this (X,Y,0) 
        {
        }

        public ThreeDPoint(double X, double Y, double Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public override string ToString()
        {
            return $"Point Coordinates:({x},{y},{z})";
        }


        public static bool operator ==(ThreeDPoint p1, ThreeDPoint p2) 
        {
            return p1.x == p2.x && p1.y == p2.y;
        }
        public static bool operator !=(ThreeDPoint p1, ThreeDPoint p2)
        {
            return p1.x != p2.x || p1.y != p2.y;
        }
        public int CompareTo(object? obj)
        {
            ThreeDPoint f = (ThreeDPoint)obj;
            if (this.x == f.x) 
            { return this.y.CompareTo(f.y); }
            else { return this.x.CompareTo(f.x); }
        }

        public object Clone() // The clone return type here is object so we need to implicitly casting in the program code
        {
            return new ThreeDPoint(this.x, this.y, this.z);
        }

        #endregion
    }
}
