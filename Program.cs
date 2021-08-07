using System;

namespace LineComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparsion Computation Program\n");

            Random rand = new Random();

            /// Line 1 co-ordinates
            int x11 = rand.Next(0, 20);
            int x12 = rand.Next(0, 20);
            int y11 = rand.Next(0, 20);
            int y12 = rand.Next(0, 20);


            /// Line 2 co-ordinates
            int x21 = rand.Next(0, 20);
            int x22 = rand.Next(0, 20);
            int y21 = rand.Next(0, 20);
            int y22 = rand.Next(0, 20);

            Line line = new Line(x11, y11, x12, y12, x21, y21, x22, y22);

            /// Calculate length
            double lineLen_1 = line.findLength1();
            double lineLen_2 = line.findLength2();

            /// Print Co-ordinates and length
            Console.WriteLine("Line 1");
            Console.WriteLine(line.getLine1());
            Console.WriteLine("length : " + lineLen_1);

            Console.WriteLine("\nLine 2");
            Console.WriteLine(line.getLine2());
            Console.WriteLine("length : " + lineLen_2);


            /// Compare lines based on length
            Console.WriteLine("\n" + line.compareTo());
        }
    }
}
