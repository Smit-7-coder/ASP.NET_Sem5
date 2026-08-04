using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial3
{
     class Student{
       private string Enrollment_No;
        private string Name;
        private string Branch;

        public void AcceptData()
        {
            Console.Write("EnrollmentNo: ");
            Enrollment_No = Console.ReadLine();

            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Branch: ");
            Branch = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("============================");
            Console.WriteLine("EnrollmentNo: "+Enrollment_No);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Branch: "+Branch);
        }
    }

    internal class P1_3
    {
        public static void Run()
        {
            Student s1 = new Student();
            s1.AcceptData();
            s1.DisplayData();

            Student s2 = new Student();
            s2.AcceptData();
            s2.DisplayData();

            Console.WriteLine("\n SAKARIYA SMIT ");

        }

    }
}
