using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P9_5
    {
        public static void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            Console.Write("Enter position to delete an element: ");
            int value = Convert.ToInt32(Console.ReadLine());

            for(int i =value-1; i<arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }

            for (int j = 0; j < arr.Length-1; j++)
            {
                Console.Write(arr[j]);
            }
        }
    }
}
