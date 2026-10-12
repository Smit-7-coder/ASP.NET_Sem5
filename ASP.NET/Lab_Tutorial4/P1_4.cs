using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial4
{
    class Employee
    {
        private int emp_code;
        private string emp_name;
        private string designation;
        private double basicPay;

        public Employee(int emp_code, string emp_name, string designation, double basicPay)
        {
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.designation = designation;
            this.basicPay = basicPay;

        }

        public void calculatorPay()
        {
            double hra = 0.10 * basicPay;
            double da = 0.45 * basicPay;
            double netSalary = basicPay + hra + da;

            Console.WriteLine("Employee Code :" + emp_code);
            Console.WriteLine("Employee Name :" + emp_name);
            Console.WriteLine("Employee Designation :" + designation);
            Console.WriteLine("Employee Salary :" + basicPay);
        }
    }
    internal class P1_4
    {
        public static void Run()
        {
            Employee e1 = new Employee(101, "Smit", "FullStcak Developer", 100000);
            e1.calculatorPay();

            Employee e2 = new Employee(101, "Marmik", "Backend Developer", 90000);
            e2.calculatorPay();

            Employee e3 = new Employee(101, "Aaryan", "Frontend Developer", 80000);
            e3.calculatorPay();
        }
    }
}
