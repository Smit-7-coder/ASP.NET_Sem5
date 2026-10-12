using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P3_5
    {
        public static void Run()
        {
            int[] arr = { 10, 20, 30, 40 };
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
