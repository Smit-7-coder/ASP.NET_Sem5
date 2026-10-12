using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1___Tutorial
{
    internal class P3
    {
        public static void Program_3()
        {
            string sentence;

            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();

            Console.WriteLine("Uppercase: " + sentence.ToUpper());
            Console.WriteLine("Spaces replaced: " + sentence.Replace(" ", "-"));
            Console.WriteLine("After trimming: " + sentence.Trim());
            Console.WriteLine("Length: " + sentence.Length);

            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");
        }
    }
}