namespace day7ReverseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "u are a good man";
            string[] words = phrase.Split(' ');
            for (int i = words.Length - 1; i >=0; i--) { 
            Console.Write($" {words[i]} ");
            
            }
        }
    }
}
