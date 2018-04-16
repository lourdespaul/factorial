using System;

namespace factorial
{
    class Program
    {
        //Recursive function to get the factorial of the integer n
        static int Fact(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            return n * Fact(n - 1);
        }
        static void Main(string[] args)
        {
            //Get input from the user
            Console.WriteLine("Enter a number to find it's factorial");
            string input = Console.ReadLine();

            //Check if the entered value an integer
            if (int.TryParse(input, out int n))
            {
                Console.WriteLine($"Factorial of {input} is {Fact(n)}");
            }
            else
            {
                Console.WriteLine($"{input} is not a number");
            }

            Console.ReadKey();
        }
    }
}
