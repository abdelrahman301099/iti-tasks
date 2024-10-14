using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Shape
{
    class Triangle : Geoshape
    {
        public Triangle()
        {

        }
        public Triangle(double _base, double _height) : base(_height, _base)
        {

        }

        public override double CArea()
        {
            return 0.5 * dim1 * dim2;
        }
    }
}
