using System;

namespace day5Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 6, -7, 8, 9, -10, 11, 12, 13, 14, };

            int max;
            int min;
            max = arr[1];
            min = arr[1];
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
                Console.Write($"{arr[i]} ");

                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }



            }
            Console.WriteLine();
            Console.WriteLine($"the max is {max}");
            Console.WriteLine($"the min {min}");

            Boolean flag = false;
            
            Console.WriteLine("Enter number to search");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0;i <= arr.Length; i++)
            {
               
                if (num==arr[i])
                {
                    
                    Console.WriteLine($"the number {arr[i]} is found in the index {i + 1}");
                   
                }
                else
                {
                    Console.WriteLine("not found");
                    
                }


            }
            
           

        }
    }
}
