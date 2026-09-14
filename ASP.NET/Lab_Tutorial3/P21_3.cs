using System;

namespace ASP.NET.Lab_Tutorial3
{
    class PersonP21
    {
        public string Name;

        public PersonP21(string name)
        {
            Name = name;
        }
    }

    class StudentP21 : PersonP21
    {
        public int EnrolmentNo;

        public StudentP21(int enrolmentNo, string name)
            : base(name)
        {
            EnrolmentNo = enrolmentNo;
        }

        
        public void Display()
        {
            Console.WriteLine("Enrolment No: " + EnrolmentNo);
            Console.WriteLine("Name: " + Name);
        }
    }

    internal class P21_3
    {
        public static void Run()
        {
            StudentP21 s = new StudentP21(101, "Smitigiri");

            s.Display();
        }
    }
}