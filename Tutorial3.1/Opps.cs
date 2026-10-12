using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial3._1
{
    public class Employee
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent Class");
        }

        public void check()
        {
            Console.WriteLine("Check method from parent class");
        }
    }

    public class RegularEmployee : Employee {
        //Data Members: from these class :
        //Data Members: from parent class : 

        //properties: from these class :
        //properties: from parent class :

        //Methods: from these class :
        //Methods: from parent class :
        private double Basic;
        private double DA;
        private double HRA;
        private double PF;
        private double PT;

        public override void Display()
        {
            Console.WriteLine("Child Class");
        }

        public new void check()
        {
            Console.WriteLine("Check method from child class");
        }

        public void Test()
        {
            Console.WriteLine("Check method from child class");
        }

    }

    internal class Opps
    {
        public static void Run()
        {
            Employee e1 = new Employee();
            e1.Display();
            e1.check();

            RegularEmployee e2 = new RegularEmployee();
            e2.Display();
            e2.check();

            //Dynamic Method Dispach
            //Call only the method that is overriden in the child class 
            //else show the parent class original method
            Employee e3 = new RegularEmployee();
            e3.Display();
            e3.check();
        }
    }
}
