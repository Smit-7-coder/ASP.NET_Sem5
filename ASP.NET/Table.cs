using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class Table
    {
        public static void mul()
        {
            int number;
            Console.Write("Enter Number: ");
            string str = Console.ReadLine();
            number = Convert.ToInt32(str);

            int result;
            for(int i= 1; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
    }
}
