using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1___Tutorial
{
    internal class P7
    {
        class Employee
        {
            public virtual void CalculateSalary()
            {
                Console.WriteLine("Employee Salary");
            }
        }

        class Manager : Employee
        {
            public override void CalculateSalary()
            {
                Console.WriteLine("Manager Salary: 50000");
            }
        }

        class Developer : Employee
        {
            public override void CalculateSalary()
            {
                Console.WriteLine("Developer Salary: 40000");
            }
        }

        public static void Program_7()
        {
            Employee manager = new Manager();
            Employee developer = new Developer();

            manager.CalculateSalary();
            developer.CalculateSalary();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");

            Console.ReadLine();
        }
    }
}