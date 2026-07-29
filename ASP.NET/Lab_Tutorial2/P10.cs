using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial2
{
    internal class P10
    {
        public static void Run()
        {
            //*
           // **
          //  ***
         //   ****
         
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=4-i; j++)
                {
                
                    Console.Write(" ");
                    
                }
                for(int k = 1; k<=i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
