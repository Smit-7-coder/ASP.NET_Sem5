using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial5
{
    internal class P6_5
    {
        public static void Run()
        {
            int[] number = { 80, 10, 20,30, 15, 50 };

            int smaller = int.MaxValue;
            int larger = int.MinValue;
            for (int i = 0; i < 6; i++)
            {
                if (number[i] < smaller)
                {
                    smaller = number[i];
                }

                if (number[i] > larger)
                {
                    larger = number[i];
                }
            }
            for (int j = 0; j < 6; j++)
            {
                if (number[j] == smaller)
                {
                    Console.WriteLine("Smaller Number is at index: " + j);
                }

                if (number[j] == larger)
                {
                    Console.WriteLine("Larger Number is at Index: " + j);
                }
            }
        }
}
}
