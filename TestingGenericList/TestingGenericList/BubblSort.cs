using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGenericList
{
    public delegate TResult SortingDelegate<in T, out TResult>(T x, T y);
    internal class BubblSort<T>
    {
        public static void Sorting(T[] arr, SortingDelegate<T, bool> sortDel)
        {
            if (arr is not null)
            {

                for (int i = 0; i < arr.Length; i++)
                {

                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (sortDel.Invoke(arr[j], arr[j + 1]))
                            {
                            SWAP(ref arr[j], ref arr[j + 1]);

                        }

                    }
                }

            }
        }

        public static void SWAP(ref T x, ref T y)
        {
            T tmp = x;
            x = y;
            y=tmp;
           
        }
    }
}
