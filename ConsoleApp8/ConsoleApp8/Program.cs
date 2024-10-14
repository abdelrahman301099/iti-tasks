namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] userInputs = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Enter the number");
                userInputs[i] = int.Parse(Console.ReadLine());




            }
            int maxValue = 0;
            int minValue = userInputs[0];
            Console.WriteLine("Enter number to search");
            int numberToFound = int.Parse(Console.ReadLine());
            string found="";
            for (int i = 0; i <= 9; i++)
            {
                if ( userInputs[i] == numberToFound)
                {
                    found = $"its found{ i}";

                }
                else
                {
                    found = "not found";
                }


                Console.WriteLine($"{userInputs[i]}");
                if (userInputs[i] > maxValue)
                {
                    maxValue = userInputs[i];
                }
                else if (userInputs[i] < minValue)
                {
                    minValue = userInputs[i];
                }
            }
            Console.WriteLine($" the max Value ====>{maxValue}");
            Console.WriteLine($" the min Value ====>{minValue}");
            Console.WriteLine(found);

        }
    }
}
