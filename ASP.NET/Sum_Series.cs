
using System;

namespace ASP.NET
{
    internal class Sum_Series
    {
        public static void Run()
        {
            int terms, number;
            int sum = 0;
            int current = 0;

            Console.Write("Input the number of terms : ");
            terms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= terms; i++)
            {
                current = current * 10 + number;

                Console.Write(current);

                sum = sum + current;

                if (i < terms)
                {
                    Console.Write(" + ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);
        }
    }
}
