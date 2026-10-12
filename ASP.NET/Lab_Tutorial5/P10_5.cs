using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P10_5
    {
        public static void Run()
        {
            int[,] arr1 =
            {
                {1,4,7 },
                {2,5,8 },
                {3,6,9 }
            };

            int[,] arr2 =
            {
                {2,3,4 },
                {6,7,8 },
                {5,9,10 }
            };

            int[,] result = new int[3, 3];

            for(int i =0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    result[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            for(int i =0; i<3; i++)
            {
                for(int j =0; j<3; j++)
                {
                    Console.Write(result[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
