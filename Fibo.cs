using System;
namespace LogicalPrograms_Day6
{
	public class Fibo
	{
		
		public static void createFibo(int stoppingPoint)
		{
            int firstNumber = 0;
            int secondNumber = 1;
			int sum = 0;
			Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            for (int i = 0; i<=stoppingPoint; i++)
			{
				sum = firstNumber + secondNumber;
				firstNumber = secondNumber;
				secondNumber = sum;
				Console.WriteLine(sum);
			}
		}
	}
}

