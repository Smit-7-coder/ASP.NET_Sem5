using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial2
{
    internal class P11
    {
        public static void Run()
        {
            int n, sum = 0;

            Console.WriteLine("Enter Size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i =0; i < n; i++)
            {

                Console.WriteLine("Enter Number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of array elements: " + sum);
            Console.WriteLine("\n25SOEIT13027 SAKARIYA SMIT");

        }
    }
}
