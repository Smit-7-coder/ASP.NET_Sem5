using System;

namespace ASP.NET
{
    internal class PrintName
    {
        public static void print()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Name: " + name);
        }
    }
}