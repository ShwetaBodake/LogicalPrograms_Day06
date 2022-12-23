using System;
namespace LogicalPrograms_Day6
{
	public class PrimeNumber
	{
		public static void PrimeNum()
		{
			int flag = 0;
			Console.WriteLine("Enter the number to check prime ");
			int number = Convert.ToInt32(Console.ReadLine());
			int limit = number / 2;
			if (number == 0 || number == 1)
			{

				Console.WriteLine("Nmuber is not prime number");
			}
			else
			{
				for (int i = 2; i <= limit; i++)
				{
					if (number % i == 0)
					{

						Console.Write("Number is not prime");
						flag = 1;
						break;
					}
				}

				if (flag == 0)
				{
					Console.Write("Number is prime");
				}
			}
		}
	}
}

