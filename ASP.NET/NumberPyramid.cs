using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class NumberPyramid
    {
        public static void Run()
        {
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(num+" ");
                    num++;
                }

                Console.WriteLine();
            }
        }
    }
}
