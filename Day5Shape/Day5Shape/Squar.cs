using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Shape
{
    class Square : Geoshape
    {
        public Square()
        {
        }
        public Square(double _dim):base(_dim,_dim)
        {
            dim1 = dim2 = _dim;
        }
        public override double CArea()
        {
            return dim1 * dim2;
        }

        

        public void SetDim(double _dim) { dim1 = dim2 = _dim; }
    }

  
}
