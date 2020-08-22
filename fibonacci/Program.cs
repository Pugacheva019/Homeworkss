using System;

namespace Fibonacci
{
	public class Program
	{
		public static int Fibonacci(int number)
		{
			if (n <= 2)
			{
				return 1;
			}
			
			return Fibonacci(number - 1) + Fibonacci(number - 2);
		}

		public static void Main()
		{
			Console.WriteLine("Enter the number of the Fibonacci number");
			var number = int.Parse(Console.ReadLine());
			if (number > 0)
			{
				Console.WriteLine($"Fibonacci number = {Fibonacci(number)}");
			}
			else
			{
				Console.WriteLine(" Wrong number");
			}
		}
	}
}
