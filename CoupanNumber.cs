using System;
namespace LogicalPrograms_Day6
{
	public class CoupanNumber
	{
		public static void Coupan()
		{
			Console.WriteLine("Enter the Number of Distint coupan needed");
			int number = Convert.ToInt32(Console.ReadLine());

			int[] coupan = new int[number];
			Random random = new Random();
			int generated = 0;
			int i = 0;
			while (i < number)
			{
				int randomnumber = random.Next(number + 1);
				generated++;
				Console.WriteLine("Random number is :" + randomnumber);

				if(coupan.Contains(randomnumber))
				{
					continue;
				}
				else
				{
					coupan[i] = randomnumber;
				}
				i++;
			}
			foreach(int coupans in coupan)
			{
				Console.WriteLine(coupans + " ");
			}

			Console.WriteLine("Random Numbers Needed to generate " + number + " number of coupans are " + generated);
		}
	}
}

