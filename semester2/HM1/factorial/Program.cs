using System;

namespace Factorial
{

    public class Program
    {
        private static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter number, please");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"factorial number = {Factorial(number)}");
        }
    }
}