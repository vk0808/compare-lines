using System;

namespace LineComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
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


            /// Initialise new instance of Line class
            Line line = new Line();


            /// Printing welcome message
            Console.WriteLine(line.Welcome() + "\n");


            /// Create line by adding respective co-ordinates
            line.AddLine1(x11, y11, x12, y12);
            line.AddLine2(x21, y21, x22, y22);
            
            /// Print Co-ordinates and length
            Console.WriteLine("Line 1");
            Console.WriteLine($"co-ordinates : {line.GetLine1()}");
            Console.WriteLine($"length : {line.GetLength1()}");

            Console.WriteLine("\nLine 2");
            Console.WriteLine($"co-ordinates : {line.GetLine2()}");
            Console.WriteLine($"length : {line.GetLength2()}");


            /// Compare lines based on length
            Console.WriteLine("\n" + line.CompareTo());
        }
    }
}
