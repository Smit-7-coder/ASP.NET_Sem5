using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1___Tutorial
{
    internal class P2
    {
        public static void Program_2()
        {
            int n, sum = 0;
            double average;

            Console.Write("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            // Accept array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate sum
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }

            // Calculate average
            average = (double)sum / n;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);

            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");
        }
    }
}