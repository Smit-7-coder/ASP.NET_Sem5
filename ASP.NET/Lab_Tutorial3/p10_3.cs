using System;

namespace ASP.NET.Lab_Tutorial3
{
    class EmployeeP10
    {
        
        public int EmployeeId;
        public string Name;
        public double BasicSalary;
        public double Allowance;
        public double Deduction;

   
        public EmployeeP10(int id, string n, double basic, double allowance, double deduction)
        {
            EmployeeId = id;
            Name = n;
            BasicSalary = basic;
            Allowance = allowance;
            Deduction = deduction;
        }

       
        public double CalculateNetSalary()
        {
            return BasicSalary + Allowance - Deduction;
        }

     
        public void Display()
        {
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("Allowance: " + Allowance);
            Console.WriteLine("Deduction: " + Deduction);
            Console.WriteLine("Net Salary: " + CalculateNetSalary());
        }
    }

    internal class p10_3
    {
        public static void Run()
        {
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string n = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            double basic = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Allowance: ");
            double allowance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Deduction: ");
            double deduction = Convert.ToDouble(Console.ReadLine());

            EmployeeP10 emp = new EmployeeP10(id, n, basic, allowance, deduction);

            Console.WriteLine("\nEmployee Details:");
            emp.Display();
        }
    }
}