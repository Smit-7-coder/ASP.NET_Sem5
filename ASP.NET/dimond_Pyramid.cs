using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class dimond_Pyramid
    {
        public static void Run()
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=i; j<5; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=(2*i-1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = 5-1; i >= 1; i--)
            {
                

                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
