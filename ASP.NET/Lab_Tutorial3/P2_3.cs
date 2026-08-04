using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial3
{
    class Clock
    {
        private int hour;
        private int min;
        private int sec;

        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        public Clock(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }

        public void Increment()
        {
            sec++;
            if(sec == 60)
            {
                sec = 0;
                min++;

                if(min == 60)
                {
                    min = 0;
                    hour++;
                    if(hour == 24)
                    {
                        hour = 0;

                    }
                }
            }
        }
        public void Display()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }

        public int GetHour()
        {
            return hour;
        }

        public int GetMinute()
        {
            return min;
        }

        public int GetSeconds()
        {
            return sec;
        }
    }
    internal class P2_3
    {
        public static void Run()
        {
            Clock c1 = new Clock();

            Console.WriteLine("Default Time:");
            c1.Display();

            Clock c2 = new Clock(10, 25, 59);

            Console.WriteLine("\nGiven Time:");
            c2.Display();

            c2.Increment();

            Console.WriteLine("\nAfter Increment:");
            c2.Display();

            Console.WriteLine("\nHour: " + c2.GetHour());
            Console.WriteLine("Minute: " + c2.GetMinute());
            Console.WriteLine("Second: " + c2.GetSeconds());

            Console.WriteLine("\n SAKARIYA SMIT ");

        }
    }
}
