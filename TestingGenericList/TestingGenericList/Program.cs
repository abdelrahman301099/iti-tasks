namespace TestingGenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> Numbers = new List<int>() { 1};
            //Numbers.Add(2);
            //Numbers.AddRange(new int[] {2,8,3,9} );
            //Console.WriteLine(Numbers.Capacity);

            //del1 del = new del1(Functions.Func1);

            //Console.WriteLine(del.Invoke("Ahmed"));


            int[] nums = { 1, 2, 3, 8, 20, 4 };

            BubblSort<int>.Sorting(nums, SortFunctions.SortAsc);
            foreach (var num in nums)
            {

                Console.WriteLine(num);
            }
            int x =5; int y =4;
            //Console.WriteLine(BubblSort.SWAP(ref x, ref y));
        }
    }
}
