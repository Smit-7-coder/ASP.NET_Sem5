using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial2
{
    internal class P3
    {
        public static void Run() {
            char firstName = 'J';

            char lastName = 'D';

            Console.WriteLine("Name: " + firstName + " " + lastName);



            Console.WriteLine("Please enter a new first name:");

            firstName = Convert.ToChar(Console.ReadLine());



            Console.WriteLine("New name: " + firstName + " " +  lastName);



            Console.ReadLine();
        }
    }
}
