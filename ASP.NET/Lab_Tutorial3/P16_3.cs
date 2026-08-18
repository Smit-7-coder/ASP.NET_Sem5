using System;

namespace ASP.NET.Lab_Tutorial3
{
    // Base class
    class Employee
    {
        public string Name { get; set; } = string.Empty;
        public double BasicSalary { get; set; }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
        }
    }

    // Derived class - Permanent Employee
    class PermanentEmployee : Employee
    {
        public double CalculateSalary()
        {
            return BasicSalary + (BasicSalary * 0.20);
        }
    }

    // Derived class - Contract Employee
    class ContractEmployee : Employee
    {
        public double CalculateSalary()
        {
            return BasicSalary + (BasicSalary * 0.10);
        }
    }

    internal class P16_3
    {
        public static void Run()
        {
            PermanentEmployee permanent = new PermanentEmployee();

            Console.Write("Enter Permanent Employee Name: ");
            permanent.Name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            permanent.BasicSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPermanent Employee Details");
            Console.WriteLine("----------------------------");
            permanent.DisplayEmployeeDetails();
            Console.WriteLine("Final Salary: " + permanent.CalculateSalary());


            ContractEmployee contract = new ContractEmployee();

            Console.Write("\nEnter Contract Employee Name: ");
            contract.Name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            contract.BasicSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nContract Employee Details");
            Console.WriteLine("----------------------------");
            contract.DisplayEmployeeDetails();
            Console.WriteLine("Final Salary: " + contract.CalculateSalary());

            Console.ReadLine();
        }
    }
}