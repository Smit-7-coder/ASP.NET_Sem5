using System;

namespace ASP.NET.Lab_Tutorial3
{
    class StudentP7
    {
        // Data members
        public int enrolmentNo;
        public string name;

        // Properties
        public int EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Default constructor
        public StudentP7()
        {
            enrolmentNo = 0;
            name = "Unknown";
        }

        // Parameterized constructor
        public StudentP7(int e, string n)
        {
            enrolmentNo = e;
            name = n;
        }

        // Method
        public void Display()
        {
            Console.WriteLine("Enrolment No: " + EnrolmentNo);
            Console.WriteLine("Name: " + Name);
        }
    }

    internal class p7_3
    {
        public static void Run()
        {
            // Creating object
            StudentP7 s1 = new StudentP7(101, "Smitigiri");

            // Display student details
            s1.Display();
        }
    }
}