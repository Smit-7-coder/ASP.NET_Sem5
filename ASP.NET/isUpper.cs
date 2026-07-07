using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    internal class isUpper
    {
        public static void Run()
        {
            string Name ,result="";
            Console.Write("Enter Your Name: ");
            Name = Console.ReadLine();

            foreach(char ch in Name)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if(char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }
                Console.WriteLine(result);
            }
        }
    }
}
