using System;

namespace ASP.NET
{
    internal class FibonacciSeries
    {
        public static void series()
        {
            int a = 0, b = 1, c;

            Console.Write(a + " " + b + " ");

            for (int i = 1; i <= 9; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}