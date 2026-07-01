using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class Factorial
    {
        public static void fact()
        {
            int number;
            Console.Write("Enter Number For Factorial: ");
            String str = Console.ReadLine();

            number = Convert.ToInt32(str);
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"the factorial of {number} is {fact}");
        }
    }
}
