using System;
namespace LogicalPrograms_Day6
{
    public class PerfectNumber
    {
        public static void DisplayPerfectNumber()
        {

            int sum = 0;
            Console.WriteLine("Enter the number :-");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {

                int reminder = number % i;
                if (reminder == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                // Console.WriteLine("{0}", number);
                Console.WriteLine("number is perfect ");
            }
            else
            {
                Console.WriteLine("number is not perfect number");
            }






        }
    }
}
