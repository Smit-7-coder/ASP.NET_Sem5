using System;

namespace ASP.NET
{
    internal class PrefixName
    {
        public static void prefix()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                Console.WriteLine("Mr. " + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
        }
    }
}