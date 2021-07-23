using System;

namespace DevBuild_Lab_Exercises
{
    //LAB 2.1: ROOM CALCULATOR
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator");
            Console.WriteLine();
            string userInput;
            do
            {
                Console.Write("Enter Length: ");
                decimal length = Decimal.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                decimal width = Decimal.Parse(Console.ReadLine());

                decimal area = length * width;
                Console.WriteLine($"Area: {area}");

                decimal perimeter = 2 * (length + width);
                Console.WriteLine($"Perimeter: {perimeter}");

                if (area <= 250)
                {
                    Console.WriteLine("This is a small-sized room.");
                }
                else if (area < 650)
                {
                    Console.WriteLine("This is a medium-sized room.");
                }
                else
                {
                    Console.WriteLine("This is a large-sized room.");
                }
                Console.WriteLine();

                Console.Write("Continue? (y/n): ");
                userInput = Console.ReadLine();
                userInput = userInput.ToUpper();
                Console.WriteLine();
            }
            while (userInput == "Y" || userInput == "YES");
          
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Room Detail Generator!");

        }
    }
}
