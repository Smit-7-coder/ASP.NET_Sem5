using System;

namespace ASP.NET.Lab_Tutorial3
{
    class CustomerP26
    {
        public string Name;

        // Constructor
        public CustomerP26(string name)
        {
            Name = name;
        }

        public void FormatName()
        {
            Name = Name.Trim();

            Name = Name.Replace("  ", " ");

            Name = Name.Insert(0, "Mr. ");

            string[] words = Name.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) +
                               words[i].Substring(1).ToLower();
                }
            }

            Name = string.Join(" ", words);
        }

        public void Display()
        {
            Console.WriteLine("Formatted Customer Name: " + Name);
        }
    }

    internal class P26_3
    {
        public static void Run()
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            CustomerP26 customer = new CustomerP26(name);

            customer.FormatName();
            customer.Display();
        }
    }
}