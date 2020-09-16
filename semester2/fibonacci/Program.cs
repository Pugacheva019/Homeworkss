using System;

namespace Fibonacci
{
    class Program
    {
        private static int Fibonacci1(int number)
        {
            if ((number == 1) || (number == 2))
            {
                return 1;
            }
            int n1 = 1;
            int n2 = 1;
            int n3 = 2;
            for (int i = 4; i <= number; i++)
            {
                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
            }
            return n3;
        }

        private static int Fibonacci2(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci2(number - 1) + Fibonacci2(number - 2);
            }
        }

        private static int Fibonacci3(int n)
        {
            if (n >= 0)
            {
                double left = (1 + Math.Sqrt(5)) / 2;
                left = Math.Pow(left, n);
                double right = (1 - Math.Sqrt(5)) / 2;
                right = Math.Pow(right, n);
                double answer = (left - right) / Math.Sqrt(5);
                return (int)answer;
            }
            return -Fibonacci3(-n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("3 method");
            Console.WriteLine(Fibonacci3(45));
            Console.WriteLine("1 Method");
            Console.WriteLine(Fibonacci1(45));
            Console.WriteLine("2 Method");
            Console.WriteLine(Fibonacci2(45));
        }
    }
}