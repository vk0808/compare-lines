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

            /// Calculate length
            double lineLen_1 = Math.Sqrt(Math.Pow(x12 - x11, 2) + Math.Pow(y12 - y11, 2) * 1.0);
            double lineLen_2 = Math.Sqrt(Math.Pow(x22 - x21, 2) + Math.Pow(y22 - y21, 2) * 1.0);

            Console.WriteLine("Line 1");
            Console.WriteLine("co-ordinates : (" + x11 + ", " + y11 + ")" + " and " + "(" + x12 + ", " + y12 + ")");
            Console.WriteLine("length : " + lineLen_1);

            Console.WriteLine("\nLine 2");
            Console.WriteLine("co-ordinates : (" + x21 + ", " + y21 + ")" + " and " + "(" + x22 + ", " + y22 + ")");
            Console.WriteLine("length : " + lineLen_2);


            if ( lineLen_1 == lineLen_2 )
            {
                Console.WriteLine("\nLine1 is equal to Line2");
            }
            else
            {
                Console.WriteLine("\nLine1 is not equal to Line2");
            }
        }
    }
}
