using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P8_5
    {
        public static void Run()
        {
            int[] arr = { 10, 20, 15, 30, 25, 35, 55, 40, 50};

            Array.Sort(arr);
            Array.Reverse(arr);

            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
