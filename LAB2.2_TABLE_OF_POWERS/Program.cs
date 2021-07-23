using System;

namespace LAB2._2_TABLE_OF_POWERS
{
    class Program
    {
        static bool KeepGoing()
        {

            while (true)
            {
                Console.Write("Continue? (y/n): ");                


                string response = Console.ReadLine();
                response = response.ToUpper();


                if (response == "Y" || response == "YES")
                {
                    return true;
                }
                else if (response == "N" || response == "NO")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");

                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
           

            do
            {
                Console.WriteLine();
                Console.Write("Enter and integer: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("=======\t\t=======\t\t======");

                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"{i}\t\t {i * i}\t\t {i * i * i}");
                }

                Console.WriteLine();

            } while (KeepGoing() == true);

        }
    }
}
