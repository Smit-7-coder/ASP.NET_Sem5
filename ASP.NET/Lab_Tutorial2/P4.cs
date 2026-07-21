using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial2
{
    internal class P4
    {
        public static void Run()
        {
            // Input
            Console.Write("Enter First Number (A): ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number (B): ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n===== Arithmetic Operators =====");
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("A * B = " + (A * B));

            if (B != 0)
            {
                Console.WriteLine("A / B = " + (A / B));
                Console.WriteLine("A % B = " + (A % B));
            }
            else
            {
                Console.WriteLine("Division and Modulus by zero not possible.");
            }

            Console.WriteLine("\n===== Assignment Operators =====");
            int x = A;
            Console.WriteLine("x = " + x);

            x += B;
            Console.WriteLine("x += B : " + x);

            x -= B;
            Console.WriteLine("x -= B : " + x);

            x *= B;
            Console.WriteLine("x *= B : " + x);

            if (B != 0)
            {
                x /= B;
                Console.WriteLine("x /= B : " + x);

                x %= B;
                Console.WriteLine("x %= B : " + x);
            }

            Console.WriteLine("\n===== Relational Operators =====");
            Console.WriteLine("A == B : " + (A == B));
            Console.WriteLine("A != B : " + (A != B));
            Console.WriteLine("A > B : " + (A > B));
            Console.WriteLine("A < B : " + (A < B));
            Console.WriteLine("A >= B : " + (A >= B));
            Console.WriteLine("A <= B : " + (A <= B));

            Console.WriteLine("\n===== Logical Operators =====");
            Console.WriteLine("(A > 0 && B > 0) : " + (A > 0 && B > 0));
            Console.WriteLine("(A > 0 || B > 0) : " + (A > 0 || B > 0));
            Console.WriteLine("!(A > B) : " + !(A > B));

            Console.WriteLine("\n===== Unary Operators =====");
            int p = A;
            Console.WriteLine("Original p = " + p);
            Console.WriteLine("++p = " + (++p));
            Console.WriteLine("--p = " + (--p));
            Console.WriteLine("p++ = " + (p++));
            Console.WriteLine("After p++ = " + p);
            Console.WriteLine("p-- = " + (p--));
            Console.WriteLine("After p-- = " + p);

            Console.WriteLine("\n===== Ternary Operator =====");
            string result = (A > B) ? "A is Greater" : "B is Greater or Equal";
            Console.WriteLine(result);

            

            Console.WriteLine("\nProgram Completed.");
}
    }
}
