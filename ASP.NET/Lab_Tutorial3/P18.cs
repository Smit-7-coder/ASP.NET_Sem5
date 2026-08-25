using System;

namespace ASP.NET.Lab_Tutorial3
{
    public class salary
    {
        public virtual void permanentEmployee()
        {
            Console.WriteLine("For Permanent Employee");
        }

        public virtual void contractEmployee()
        {
            Console.WriteLine("For Contract Employee");
        }
    }

    public class Permanent : salary
    {
        public override void permanentEmployee()
        {
            Console.WriteLine("Permanent Employee Salary Slip");
            Console.WriteLine("Basic Salary : 30000");
            Console.WriteLine("HRA          : 6000");
            Console.WriteLine("DA           : 3000");
            Console.WriteLine("Gross Salary : 39000");
        }
    }


    public class Contract : salary
    {
        public override void contractEmployee()
        {
            Console.WriteLine("Contract Employee Salary Slip");
            Console.WriteLine("Contract Salary : 25000");
        }
    }

    internal class P18
    {
        public static void Run()
        {
            salary s1 = new Permanent();
            salary s2 = new Contract();

            s1.permanentEmployee();
            Console.WriteLine();

            s2.contractEmployee();

            Console.ReadLine();
        }
    }
}