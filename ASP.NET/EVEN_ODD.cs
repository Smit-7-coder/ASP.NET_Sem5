using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    public class EVEN_ODD
    {
        public static void Evenodd() 
        {
            int number;
            Console.Write("Enter Number: ");

            string str = Console.ReadLine();
            number = Convert.ToInt32(str);

            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }
        }
    }
}
