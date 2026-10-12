using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P5_5
    {
        public static void Run()
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 1, 5, 3, 6 };

            for (int i = 0; i < 4; i++)
            {
                bool isCommon = false;

                for (int j = 0; j < 4; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        isCommon = true;
                        break;
                    }
                }
                if (isCommon)
                {
                    Console.WriteLine(arr1[i]);
                }
            }
        }
    }
}
