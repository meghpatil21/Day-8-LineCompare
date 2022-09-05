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
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}