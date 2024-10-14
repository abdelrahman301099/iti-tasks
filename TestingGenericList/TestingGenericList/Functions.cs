using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGenericList
{
    public delegate int del1(string str);
    internal class Functions
    {
        public static int Func1(string str)
        {
            int count = 0;
            if (str is not null) {
                for (int i = 0; i < str.Length; i++) {
                    if (char.IsUpper(str[i])) {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
