namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation.");
            Console.WriteLine();

            Console.WriteLine("Select option from following: \n1.Lengh of Line");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LineCompare.LengthLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}