using System;

namespace ASP.NET
{
    internal class ToggleCase
    {
        public static void toggle()
        {
            Console.Write("Enter a Name: ");
            string str = Console.ReadLine();

            string result = "";

            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }
            }

            Console.WriteLine("Toggle Case: " + result);
        }
    }
}