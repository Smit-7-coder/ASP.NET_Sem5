using System;

namespace ASP.NET.Lab_Tutorial3
{
    
    class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
    }

 
    internal class P15_3 : Person
    {
        public string EnrollmentNo { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;

        public static void Run()
        {
            P15_3 student = new P15_3();

            
            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address: ");
            student.Address = Console.ReadLine();

            // Accept student information
            Console.Write("Enter Enrollment Number: ");
            student.EnrollmentNo = Console.ReadLine();

            Console.Write("Enter Course: ");
            student.Course = Console.ReadLine();

            // Display complete details
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("------------------------");
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Enrollment Number: " + student.EnrollmentNo);
            Console.WriteLine("Course: " + student.Course);

            Console.ReadLine();
        }
    }
}