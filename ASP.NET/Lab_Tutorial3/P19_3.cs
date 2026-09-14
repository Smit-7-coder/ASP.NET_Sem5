using System;

namespace ASP.NET.Lab_Tutorial3
{
    class StudentP19
    {
        public int Id;
        public string Name;

        // Static data member
        public static int Count = 0;

        // Constructor
        public StudentP19(int id, string name)
        {
            Id = id;
            Name = name;
            Count++;
        }

        // Method
        public void Display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
        }
    }

    internal class P19_3
    {
        public static void Run()
        {
            StudentP19 s1 = new StudentP19(101, "Smitigiri");
            StudentP19 s2 = new StudentP19(102, "Rahul");
            StudentP19 s3 = new StudentP19(103, "Jeni");

            s1.Display();
            Console.WriteLine();

            s2.Display();
            Console.WriteLine();

            s3.Display();

            Console.WriteLine("\nTotal Students Created: " + StudentP19.Count);
        }
    }
}