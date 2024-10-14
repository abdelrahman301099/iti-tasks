using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day9Tasks
{
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D()
        {

            X = 0; Y = 0; Z = 0;
        }
        public Point3D(int _x, int _y, int _z)
        {

            X = _x; Y = _y; Z = _z;

        }
        public override string ToString()
        {
            return $"X: {X} Y: {Y} Z: {Z}";
        }

        public static explicit operator string(Point3D p)
        {
            return p.ToString() ;
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return (left.X == right.X) && (left.Y == right.Y) && (left.Z == right.Z);
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return (left.X != right.X) || (left.Y != right.Y) || (left.Z != right.Z);
        }
    }
}
