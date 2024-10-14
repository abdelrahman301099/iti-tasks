using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testIsEqual
{
    class Mega<T>
    {
        public static int SearchInArr(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++) { 
                if(value.Equals(arr[i]))
                    {
                        return i;
                    }
                }

            }
            return -1;
        }
    }
}
