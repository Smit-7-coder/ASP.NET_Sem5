using System;

namespace ASP.NET.Lab_Tutorial3
{
    class UserP22
    {
        public string Name = "Base User";

        public void Display()
        {
            Console.WriteLine("User Name: " + Name);
        }
    }

    class StudentP22 : UserP22
    {
        public new string Name = "Student";

        public new void Display()
        {
            Console.WriteLine("Student Name: " + Name);
        }
    }

    internal class P22_3
    {
        public static void Run()
        {
            StudentP22 s = new StudentP22();

            s.Display();
        }
    }
}