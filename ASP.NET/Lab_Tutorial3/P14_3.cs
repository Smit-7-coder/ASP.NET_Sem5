using System;

namespace ASP.NET.Lab_Tutorial3
{
    internal class P14_3
    {

        private double salary;


        public void SetSalary(double amount)
        {
            if (amount > 0)
            {
                salary = amount;
            }
            else
            {
                Console.WriteLine("Invalid salary amount.");
            }
        }

        public double GetSalary()
        {
            return salary;
        }

        public static void Run()

        {
            P14_3 employee = new P14_3();

            Console.Write("Enter Employee Salary: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            
            employee.SetSalary(amount);

            Console.WriteLine("Employee Salary: " + employee.GetSalary());

            Console.ReadLine();
        }
    }
}