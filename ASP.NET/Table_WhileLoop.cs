using System;

namespace ASP.NET
{
    internal class Table_WhileLoop
    {
        public static void table()
        {
            int num1, res, i;

            Console.Write("Enter a Number: ");
            string str = Console.ReadLine();

            num1 = Convert.ToInt32(str);

            i = 1;

            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine($"{num1} x {i} = {res}");

                i++;
            }
        }
    }
}