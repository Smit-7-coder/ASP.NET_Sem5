using System;

namespace ASP.NET.Lab_Tutorial3
{
    class ClockP9
    {
        // Data members
        public int Hour;
        public int Minute;
        public int Second;

        // Constructor
        public ClockP9(int h, int m, int s)
        {
            Hour = h;
            Minute = m;
            Second = s;
        }

        // Method to display time
        public void DisplayTime()
        {
            Console.WriteLine("Time: " + Hour + ":" + Minute + ":" + Second);
        }

        // Method to increment time by one second
        public void IncrementSecond()
        {
            Second++;

            if (Second >= 60)
            {
                Second = 0;
                Minute++;
            }

            if (Minute >= 60)
            {
                Minute = 0;
                Hour++;
            }

            if (Hour >= 24)
            {
                Hour = 0;
            }
        }
    }

    internal class p9_3
    {
        public static void Run()
        {
            Console.Write("Enter Time (HH:MM:SS): ");
            string input = Console.ReadLine();

            // Split the entered time
            string[] time = input.Split(':');

            int h = Convert.ToInt32(time[0]);
            int m = Convert.ToInt32(time[1]);
            int s = Convert.ToInt32(time[2]);

            // Create clock object
            ClockP9 clock = new ClockP9(h, m, s);

            // Display current time
            Console.WriteLine("\nCurrent Time:");
            clock.DisplayTime();

            // Increment by one second
            clock.IncrementSecond();

            // Display updated time
            Console.WriteLine("After Incrementing One Second:");
            clock.DisplayTime();
        }
    }
}