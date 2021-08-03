using System;

namespace LineComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparsion Computation Program");

            Random rand = new Random();
            
            /// Line 1 co-ordinates
            int x1 = rand.Next(0, 20);
            int x2 = rand.Next(0, 20);
            int y1 = rand.Next(0, 20);
            int y2 = rand.Next(0, 20);

            /// Calculate length
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);

            Console.WriteLine("(" + x1 + ", " + y1 + ")");
            Console.WriteLine("(" + x2 + ", " + y2 + ")");
            Console.WriteLine("Length: " + length);
        }
    }
}
