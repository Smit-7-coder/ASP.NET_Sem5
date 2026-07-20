using System;

namespace ASP.NET
{
    internal class dimond_Pyramid
    {
        public static void Run()
        {
            // Upper Pyramid
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Lower Pyramid
            for (int i = 4; i >= 1; i--)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}