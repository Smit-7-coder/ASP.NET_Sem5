using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P2_5
    {
        public static void Run()
        {
            int[] arr = { 4, 3, 2, 1 };

            int start = 0;
            int end = 3;
            int size = 4;

            while(end > start)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                
                start++;
                end--;
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
