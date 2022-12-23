using System;
namespace LogicalPrograms_Day6
{
	public class ReverseNumber
	{
        public static void DisplayReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a number ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;

            }
            Console.WriteLine("Reversed number " + reverse);
        }
    }
}

