using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Shape
{
    abstract class Geoshape
    {
        protected double dim1;
        protected double dim2;

        public Geoshape()
        {
            dim1 = dim2 = 0;
           
        }
        public Geoshape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
            
        }
        protected void SetDim1(double _dim1)
        {
            dim1 = _dim1;
        }
        protected void SetDim2(double _dim2)
        {
            dim2 = _dim2;
        }
        public double GetDim1()
        {
            return dim1;
        }
        public double GetDim2()
        {
            return dim2;
        }
     
        public Geoshape(Geoshape _geoshape)
        {
            dim1 = _geoshape.dim1;
            dim2 = _geoshape.dim2;
        }

        public abstract double CArea();

    }
}
