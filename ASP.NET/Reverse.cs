using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class Reverse
    {
        public static void Run()
        {
            //Algorithm
            //1. Read the input string
            //2. create an empty string named rev
            //3. Traverse the string from the last character to the first
            //4. Append each character to rev
            //5. Display The reversed string.


            string name, reverse ="";
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();


            for (int i = name.Length-1; i>=0; i--)
            {
                reverse = reverse + name[i];
            }
            Console.WriteLine(reverse);
            //if(reverse == name)
            //{
            //    Console.WriteLine("String is Plaindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Srting is not Plaindrome");
            //}
        }
    }
}
