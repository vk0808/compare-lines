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

        public Line(int x11, int y11, int x12, int y12, int x21, int y21, int x22, int y22)
        {
            this.x11 = x11;
            this.y11 = y11;
            this.x12 = x12;
            this.y12 = y12;
            this.x21 = x21;
            this.y21 = y21;
            this.x22 = x22;
            this.y22 = y22;
        }

        public string getLine1()
        {
            return "co-ordinates : (" + x11 + ", " + y11 + ")" + " and " + "(" + x12 + ", " + y12 + ")";
        }

        public string getLine2()
        {
            return "co-ordinates : (" + x21 + ", " + y21 + ")" + " and " + "(" + x22 + ", " + y22 + ")";
        }


        public double findLength1()
        {
            return (Math.Sqrt(Math.Pow(this.x12 - this.x11, 2) + Math.Pow(this.y12 - this.y11, 2) * 1.0));
        }

        public double findLength2()
        {
            return (Math.Sqrt(Math.Pow(this.x22 - this.x21, 2) + Math.Pow(this.y22 - this.y21, 2) * 1.0));
        }

        public string equalTo()
        {
            if(this.findLength1() == this.findLength2())
            {
                return "Line 1 is equal to Line 2";
            }
            return "Line 1 is not equal to Line 2";
        }

        public string compareTo()
        {
            if(this.findLength1() > this.findLength2())
            {
                return "Line 1 is greater than Line 2";
            }
            return "Line 1 is less than Line 2";
        }
    }
}
