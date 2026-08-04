using System;

namespace ASP.NET.Lab_Tutorial2
{
    internal class P5
    {
        public static void Run()
        {
            int[] arr = new int[5];
            int sum = 0;

            // Input elements
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());

                sum = sum + arr[i];
            }

            // Display sum
            Console.WriteLine("\nSum of Elements : {0}", sum);
            Console.WriteLine("\n25SOEIT13027 SAKARIYA SMIT");
            Console.ReadKey();
        }
    }
}