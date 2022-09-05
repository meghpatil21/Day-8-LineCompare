using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LineCompare
    {
        public static void LengthLine()
        {
            Console.WriteLine("Enter X Co-ordinates of first point: ");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinates of first point: ");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X Co-ordinates of second point: ");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X Co-ordinates of second point: ");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            double x = (x2 - x1) * (x2 - x1);
            double y = (y2 - y1) * (y2 - y1);

            double lengthOfLine = Math.Sqrt(x + y);
            lengthOfLine = System.Math.Round(lengthOfLine, 2);
            Console.WriteLine("Lengh of line is " + lengthOfLine);
        }
    }
}
