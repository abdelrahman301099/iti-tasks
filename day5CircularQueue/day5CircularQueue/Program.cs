namespace day5CircularQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularQueue c1= new CircularQueue(5);
            c1.Add(1);
            c1.Add(2);
            c1.Add(3);
            c1.Add(4);
            c1.Add(5);
            
            c1.Delete();
            c1.Delete();
            c1.Delete();
            c1.Delete();
            c1.Add(1);
            c1.Add(2);
            c1.Add(3);
            c1.Add(4);
            c1.Delete();
            c1.Delete();
            c1.Delete();
            c1.Delete();
            c1.Add(9);

            c1.PrintQueue();    
        }
    }
}
