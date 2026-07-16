using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class NumberIncreased_Pattern
    {
        public static void Run()
        {
            int count = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count);
                    count++;

                }
                Console.WriteLine();
            }
        }
    }
}
