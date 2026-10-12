using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P7_5
    {
        public static void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] even = new int[9];
            int[] odd = new int[9];
            int e = 0, o = 0;

            for(int i = 0; i<9; i++)
            {
                if (arr[i] %2 == 0)
                {
                    even[i] = arr[i];
                    e++;
                }
                else
                {
                    odd[i] = arr[i];
                    o++;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.Write(even[j]+" ");
            }
            Console.WriteLine();
            for (int K = 0; K < 9; K++)
            {
                Console.Write(odd[K] + " ");
            }
        }
    }
}
