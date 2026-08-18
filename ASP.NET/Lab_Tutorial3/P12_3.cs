using System;

namespace ASP.NET.Lab_Tutorial3
{
    internal class P12_3
    {
        // Properties
        public string EnrollmentNo { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public static void Run()
        {
            P12_3 student = new P12_3();

            // Accept values
            Console.Write("Enter Enrollment Number: ");
            student.EnrollmentNo = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();

            // Display values
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enrollment Number: " + student.EnrollmentNo);
            Console.WriteLine("Student Name: " + student.Name);

            Console.ReadLine();
        }
    }
}