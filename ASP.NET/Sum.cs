using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class Sum
    {
        public static void add()
        {
            int a, b, c, result;
            Console.Write("Enter Number 1: ");
            String str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2: ");
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3: ");
            c = Convert.ToInt32(str);

            int Addition = a + b + c;
            Console.WriteLine($"Addition of three number is{Addition}");

            int Substraction = a - b - c;
            Console.WriteLine($"Addition of three number is{Substraction}");

            int Division = a / b / c;
            Console.WriteLine($"Addition of three number is{Division}");

            int Multiplication = a * b * c;
            Console.WriteLine($"Addition of three number is{Multiplication}");

        }
        
    }
}
