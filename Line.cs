using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparsion
{
    public class Line
    {
        int x11;
        int y11;
        int x12;
        int y12;
        int x21;
        int y21;
        int x22;
        int y22;

        public void AddLine1(int x1, int y1, int x2, int y2)
        {
            this.x11 = x1;
            this.y11 = y1;
            this.x12 = x2;
            this.y12 = y2;
        }

        public void AddLine2(int x1, int y1, int x2, int y2)
        {
            this.x21 = x1;
            this.y21 = y1;
            this.x22 = x2;
            this.y22 = y2;
        }

        public string Welcome()
        {
            return "Welcome to Line Comparsion Computation Program";
        }

        private string LineCoOrdinates(int x1, int y1, int x2, int y2)
        {
            return "(" + x1 + ", " + y1 + ")" + " and " + "(" + x2 + ", " + y2 + ")";
        }

        public string GetLine1()
        {
            return LineCoOrdinates(x11, y11, x12, y12);
        }

        public string GetLine2()
        {
            return LineCoOrdinates(x21, y21, x22, y22);
        }


        private double FindLength(int x1, int y1, int x2, int y2)
        {
            return (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0));
        }

        public double GetLength1()
        {
            return FindLength(x11, y11, x12, y12);
        }

        public double GetLength2()
        {
            return FindLength(x21, y21, x22, y22);
        }

        public string EqualTo()
        {
            if(this.GetLength1() == this.GetLength2())
            {
                return "Line 1 is equal to Line 2";
            }
            return "Line 1 is not equal to Line 2";
        }

        public string CompareTo()
        {
            if(this.GetLength1() > this.GetLength2())
            {
                return "Line 1 is greater than Line 2";
            }
            return "Line 1 is less than Line 2";
        }
    }
}
