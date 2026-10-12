using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P4_5
    {
        public static void Run()
        {
            int[] arr = { 10, 20, 30, 40 };
            int[] result = new int[4];

            for(int i = 0; i<4; i++)
            {
                result[i] = arr[i];
                
            }
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(result[j]);

            }


        }
    }
}
