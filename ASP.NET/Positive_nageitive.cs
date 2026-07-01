using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class Positive_nageitive
    {
        public static void run()
        {
            int number;
            Console.Write("Enter Number: ");
            String str = Console.ReadLine();

            number = Convert.ToInt32(str);

            if(number >= 1)
            {
                Console.WriteLine($"{number} is Positive");
            }
            else if(number == 0)
            {
                Console.WriteLine($"{number} is equal to zero");

            }
            else
            {
                Console.WriteLine($"{number} is Negative");
            }
        }
    }
}
