namespace day7OnesTask
{
    internal class Program
    {
       

        static void Main()
        {

            //s1
            //int count = 0;

            //for (int i = 0;i < 999; i++)
            //{
            //    string num = i.ToString();
            //    for (int j = 0; j < num.Length; j++) {
            //        if (num[j] == '1') {
            //            count++;
            //                }
            //    }


            //}
            //    Console.WriteLine(count);






            //s2
            // int num = 19;
            //int count = 0;
            // for (int i = 0; i < num; i++) {
            //     int val = i;
            //     while (val > 0) {
            //         if (val %10 ==1) {
            //             count++;
            //         }
            //         val /=10;
            //     }
            // }
            // Console.WriteLine(count);



            //s3

            int number = 9999;
            int numL = number.ToString().Length;
            int count = (int)(numL * Math.Pow(10, numL - 1));
            Console.WriteLine(count);







        }
    }
}