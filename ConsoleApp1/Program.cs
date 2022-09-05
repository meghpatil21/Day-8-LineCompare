using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation.");
            Console.WriteLine();

            Console.WriteLine("Select option from following: \n1.Lengh of Line \n2.Check equality of two lines \n3.Compare two lines \n4.compare using oops");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LineCompare.LengthLine();
                    break;
                case 2:
                    EqualOrNot.LineEqualCheck();
                    break;
                case 3:
                    Compare2Method.CompareLength();
                    break;
                case 4:
                    double l1, l2;
                    Oops oops=new Oops();
                    Console.WriteLine("Enter x coordinate of 1st point");
                    oops.OneCo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter y coordinate of 1st point");
                    oops.ThirdCo=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter x coordinate of 2nd point");
                    oops.TwoCo=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter y coordinate of 2nd point");
                    oops.FourthCo = Convert.ToDouble(Console.ReadLine());
                    oops.CalculationX = 0;
                    oops.CalculateCalculationY = 0;
                    oops.LengthLine = 0;
                    
                    Console.WriteLine("length of 1st line is "+oops.LengthLine);
                    Console.WriteLine();
                    oops.LengthLine2();
                    

                    


                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}