using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Oops
    {
        private double x1, x2, y1, y2, x = 0, y = 0, lengthOfLine = 0, lTwo = 0;

        public double OneCo
        {
            get { return x1; }
            set { x1 = value; }

        }
        public double TwoCo
        {
            get { return x2; }
            set { x2 = value; }
        }
        public double ThirdCo
        {
            get { return y1; }
            set { y1 = value; }
        }
        public double FourthCo
        {
            get { return y2; }
            set { y2 = value; }
        }

        public double CalculationX
        {
            get { return x; }
            set { x = (x2 - x1) * (x2 - x1); }

        }

        public double CalculateCalculationY
        {
            get { return y; }
            set { y = (y2 - y1) * (y2 - y1); }
        }

        public double LengthLine
        {
            get { return lengthOfLine; }
            set { lengthOfLine = Math.Sqrt(x + y); }
        }

        public  void LengthLine2()
        {
            Console.WriteLine("Enter X Co-ordinates of first point: ");
            Double xx1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinates of first point: ");
            Double xy1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X Co-ordinates of second point: ");
            Double xx2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X Co-ordinates of second point: ");
            Double xy2 = Convert.ToDouble(Console.ReadLine());

            double xx = (xx2 - xx1) * (xx2 - xx1);
            double xy = (xy2 - xy1) * (xy2 - xy1);

            double lengthOfLine2 = Math.Sqrt(xx + xy);

            Console.WriteLine("Lengh of 2nd line is " + lengthOfLine2);

            double l2 = lengthOfLine2;
            double l1 = lengthOfLine;
            Console.WriteLine();
            Console.WriteLine("comparing 2nd line with 1st line:\n 0=same\t 1=greater\t -1=smaller");
            Console.WriteLine();
            Console.WriteLine("Result is "+l2.CompareTo(l1));
        }

    }
    
}
