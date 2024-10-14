using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Shape
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace InheritanceV2
    {
        class Utility
        {
            
            public static double SumOfAreas(Rectangle r, Square s, Triangle t)
            {
                double sum = 0;
                sum += r.CArea();
                sum += s.CArea();
                sum += t.CArea();
                return sum;
            }

            
            public static double SumOfAreas(Geoshape[] _shapes)
            {
                double sum = 0;
                for (int i = 0; i < _shapes.Length; i++)
                {
                    sum += _shapes[i].CArea();
                }
                return sum;
            }
        }



      
    }

}
