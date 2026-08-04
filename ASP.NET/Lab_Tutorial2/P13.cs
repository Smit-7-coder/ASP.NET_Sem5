using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial2
{
    internal class P13
    {
        public static void Run()
        {

            Console.Write("Enter Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            foreach (int note in notes)
            {
                int count = amount / note;
                amount = amount % note;
                Console.WriteLine("Notes of Rs." + note + " = " + count);
            }
            Console.WriteLine("\n25SOEIT13027 SAKARIYA SMIT");

        }
    }
}
