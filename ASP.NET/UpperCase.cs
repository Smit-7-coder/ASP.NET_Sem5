using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class UpperCase
    {
        public static void Run()
        {

            string Name;
            Console.Write("Enter Your Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("UpperCase Result is: " + Name.ToUpper());
        }
    }
}
