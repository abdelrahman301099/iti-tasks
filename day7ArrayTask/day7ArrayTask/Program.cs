namespace day7ArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 8, 22, 3, 1, 18, 2, 13, 13, 13 };

            int counter =0;




            //int[] spaces = new int[arr.Length];
            int max = 0;
            
            while (counter < arr.Length)
            {
                int num = arr[counter];
                for (int i = counter; i < arr.Length; i++)
                {
                 if(  num == arr[i])
                    {
                        //spaces[i] = (i - counter);
                        if ((i- counter) > max)
                        {
                            max = (i-counter);
                        }

                    }

                }
                
                counter++;
            }
                    Console.WriteLine(max);


            //for (int i = 0; i < spaces.Length; i++) { 
            //}

        }
    }
}
