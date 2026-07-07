using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class mobileNumber
    {
        public static void Run()
        {
            string Number, result="";
            Console.Write("Enter Your Mobile Number: ");
            Number = Console.ReadLine();
            for(int i =0; i <= Number.Length; i++)
            {
                if(i < Number.Length - 5)
                {
                    result += Number[i];
                }
                else
                {
                    result += "X";
                }
            }
            Console.WriteLine(result);
        }
    }
}
