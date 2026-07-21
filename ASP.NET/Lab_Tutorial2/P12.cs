using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NET
{
    internal class P12
    {
        public static void Run()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the array elements:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the element to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int found = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == search)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);

            Console.ReadLine();
        }
    }
}