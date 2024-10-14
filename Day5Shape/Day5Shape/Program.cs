using Day5Shape.InheritanceV2;

namespace Day5Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5, 4);
            Square s1 = new Square(10);
            Triangle t1 = new Triangle(3, 7);
            Circle c1 = new Circle(7);
            Geoshape g1 = new Rectangle(8, 4);
            

            Geoshape[] shapes = { r1, s1, t1, c1, g1 };
            Console.WriteLine( Utility.SumOfAreas(shapes));

        }
    }
}
