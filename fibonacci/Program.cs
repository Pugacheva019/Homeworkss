using System;

namespace Fibonacci
{
	public class Program
	{
		public static int Fibonacci(int number)
		{
			if (number == 1 || number == 2)
			{
				return number -= 1;
			}
			return Fibonacci(number - 1) + Fibonacci(number - 2);
		}

		public static void Main()
		{
			Console.WriteLine("Enter the number of the Fibonacci number");
			var number = int.Parse(Console.ReadLine());
			Console.WriteLine($"Fibonacci number = {Fibonacci(number)}");
		}
	}
}