using System;

namespace ASP.NET.Lab_Tutorial3
{
    class StudentP8
    {
        
        public int EnrolmentNo;
        public string Name;
        public string Course;

       
        public StudentP8()
        {
            EnrolmentNo = 0;
            Name = "Unknown";
            Course = "Unknown";
        }

       
        public StudentP8(int e, string n, string c)
        {
            EnrolmentNo = e;
            Name = n;
            Course = c;
        }

        
        public void Display()
        {
            Console.WriteLine("Enrolment No: " + EnrolmentNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Course: " + Course);
        }
    }

    internal class p8_3
    {
        public static void Run()
        {
            Console.Write("Enter Enrolment No: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string n = Console.ReadLine();

            Console.Write("Enter Course: ");
            string c = Console.ReadLine();

            StudentP8 s = new StudentP8(e, n, c);

            Console.WriteLine("\nStudent Details:");
            s.Display();
        }
    }
}