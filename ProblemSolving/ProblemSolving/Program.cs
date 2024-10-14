using System.Numerics;
using System.Runtime.CompilerServices;

namespace ProblemSolving
{
    class ExtentionMethods
    {
        static bool ReversedInt(this IComparable num)
        {
            int x = num;
            int reversedNum = 0, reminder;
            while (num != 0)
            {
                reminder = num % 10;
                reversedNum = reversedNum * 10 + reminder;
                num = num / 10;
            }
            return (x == reversedNum);
        }
    }
    internal class Program

    {     //EX01
          //static string ToHex(int num)
          //{
          //    if (num == 0)
          //    {
          //        return "0";
          //    }

        //    char[] hexChars = "0123456789abcdef".ToCharArray();
        //    string result = "";
        //    int mask = 0xf;

        //    if (num < 0)
        //    {
        //        num += (1 << 32);
        //    }

        //    while (num > 0)
        //    {
        //        int digit = num & mask;
        //        result = hexChars[digit] + result;
        //        num >>= 4;
        //    }

        //    return result;
        //}




        //EX02
        //static int[] sumTarget(int[] nums, int target) {



        //    for (int i = 0; i < nums.Length; i++)
        //        {
        //            for (int j = i + 1; j < nums.Length; j++)
        //            {
        //                if (target == nums[i] + nums[j])
        //                {
        //                    return new int[] { nums[i],nums[ j] };
        //                }
        //            }
        //        }


        //    return null;
        //}

        //EX04
        

        static bool Palendrome(int x)
        {
            string[] strx = x.ToString().Split(',');
            return false;
        }

        static void Main(string[] args)
        {
            //EX01
            //    int num = 12;
            //    Console.WriteLine(ToHex(num));


            //EX02
            // int[] nums = { 1, 2, 3, 5 ,8, 4 };
            // int target = 4;
            // foreach (var item in sumTarget(nums, target))
            // {

            //Console.WriteLine(item);
            // }



            // //EX03

            //LinkedList<int> l1 = new LinkedList<int>();
            //l1.AddLast(5);
            //l1.AddLast(2);
            //l1.AddLast(4);
            //LinkedList<int> l2 = new LinkedList<int>();
            //l2.AddLast(4);
            //l2.AddLast(3);
            //l2.AddLast(1);


            //int V = 0;
            //foreach (var item in l1.Reverse())
            //{

            //    V += item;
            //}
            //int l2rstr =0;
            //foreach (var item in l2.Reverse())
            //{

            //    l2rstr += item;
            //}
            //int result = V * l2rstr;
            //Console.WriteLine(result);


            //EX04
            //int x = 122;
            //string xS = x.ToString();
            //string xR = x.ToString().Reverse().ToString();

            //Console.WriteLine(xS[1]);
            //Console.WriteLine(xR[5]);

            //Console.WriteLine(ReversedInt(123));

            int x = 121;
            Console.WriteLine(ReversedInt(x));


            
        }
    }
}
