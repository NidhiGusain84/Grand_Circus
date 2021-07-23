using System;

namespace Optional_Lab_2_4 //FACTORIAL CALCULATOR
{
    class Program
    {
        static bool GetResponse()
        {
            while (true)
            {
                Console.Write("Continute? (y/n): ");

                string userInput = Console.ReadLine();
                Console.WriteLine();
                userInput = userInput.ToUpper();

                if (userInput == "Y" || userInput == "YES")
                {
                    return true;
                }
                else if (userInput == "N" || userInput == "NO")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Caculator!");
            Console.WriteLine();

            float userNum, i, factorial;
            do
            {
                Console.Write("Enter an integer that's greater than 0 but less than 10: ");
                userNum = float.Parse(Console.ReadLine());
                factorial = userNum;

                for (i = userNum - 1; i >= 1; i--)
                {
                    factorial = factorial * i;
                }


                Console.WriteLine($"The factorial of {userNum} is {factorial}. ");
                Console.WriteLine();

            }
            while (GetResponse());


        }
    }
}
