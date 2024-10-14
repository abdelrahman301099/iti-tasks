namespace Arr2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[3, 3];

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.Clear();

            //for (int j = 0; j < arr.Length; j++)
            //{
            //    Console.WriteLine(arr[j / arr.GetLength(1), j % arr.GetLength(1)]);
            //}

            //Object o1 = new object();
            //int x = (int)o1;
            int? n = null;
           int l=(int) n;
          l = n.HasValue ? n.Value : 0;
            l = n ?? 0;
            Console.WriteLine(l);


            //for (int i = 0;i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0;j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr[i,j]);
            //    }

            //}

        }
    }
}
