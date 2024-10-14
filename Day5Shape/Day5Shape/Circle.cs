using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Shape
{
    class Circle : Geoshape
    {
        public Circle()
        {

        }
        public Circle(double _radius) : base(_radius, _radius)
        {

        }

        public override double CArea()
        {

            return 3.14 * dim1 * dim2;

        }
    }
}
