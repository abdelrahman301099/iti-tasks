namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDarr = new int[3, 4];
            for (int i = 0; i < twoDarr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDarr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter # at index {i},{j}");
                    twoDarr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < twoDarr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDarr.GetLength(1); j++)
                {
                    Console.Write($"{twoDarr[i, j]} \t");
                }
                Console.WriteLine();
            }


        }
    }
}
