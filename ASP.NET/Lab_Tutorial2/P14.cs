using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial2
{
    internal class P14
    {
        public static void Run()
        {
            Console.Write("Enter Maths Marks: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Physics Marks: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry Marks: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int total = maths + physics + chemistry;

            if ((maths >= 65 && physics >= 55 && chemistry >= 50 &&
                 total >= 180) ||
                (maths >= 65 && physics >= 55 &&
                 (maths + physics) >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.WriteLine("\n25SOEIT13027 SAKARIYA SMIT");

        }
    }
}
