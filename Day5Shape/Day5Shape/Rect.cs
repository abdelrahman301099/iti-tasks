using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Shape
{
    class Rectangle : Geoshape
    {
        public Rectangle()
        {
            
            Console.WriteLine("rect def ctor");
        }

        public Rectangle(double _d1, double _d2) : base(_d1, _d2)
        {
            
        }

        public override double CArea()
        {
            return dim1 * dim2;
        }

    }
}
