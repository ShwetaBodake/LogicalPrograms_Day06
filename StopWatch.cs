using System;
namespace LogicalPrograms_Day6
{
	public class StopWatch
	{
        static int stopTime = 0;
        static int startTime = 0;
		public static void start()
		{
            DateTime dt = DateTime.Now;
            startTime = dt.Millisecond;
            
        }

        public static void stop()
        {
            DateTime dt = DateTime.Now;
            stopTime = dt.Millisecond;

        }

        public static void stopWatch()
        {
            Console.WriteLine("Enter 1 to start the watch");
            int startCounter = Convert.ToInt32(Console.ReadLine());
            if(startCounter == 1)
            {
                start();
            }

            Console.WriteLine("Enter 2 to start the watch");
            int stopCounter = Convert.ToInt32(Console.ReadLine());
            if (stopCounter == 2)
            {
                stop();
            }
            int timeElapsed = startTime - stopTime;

            Console.WriteLine("Time elapsed: " + timeElapsed);



        }
    }
}

