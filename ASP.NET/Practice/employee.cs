using System;

namespace ASP.NET.Practice
{
    class emp //blue print of employee class
    {
        //data members
        public string Name { get; set; }
        private int age;//data member
        public string Dept { get; set; }
        protected double Salary;

        //it does not have any return type explicilty
        //must have same name as class name
        public emp()//default constructor or zero parameter constructor
        {

        }
        public emp(string Name, int age, string Dept, double Salary)//parameterized constructor
        {

        }
        public void serSalary(double Salary)
        {
            this.Salary = Salary;
        }
        public double getSalary()
        {
            return Salary;
        }
        public int Age
        {
            get//read only property
            {
                return age;
            }
            set // write only property
            {
                if (value >= 18)
                    age = value;
                else
                    age = -1;
            }
        }
        //method -- to work with the data members
        public virtual void display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Dept: " + Dept);
            Console.WriteLine("Salary: " + Salary);
        }
        public void check()
        {
            Console.WriteLine("This is check method from Employee class");
        }
    }
    class regularemployee : emp
    {
        //data members:from this class:5
        //data members:from parent class(Employee):3

        //properties:from this class:0
        //properties:from parent class(Employee):1

        //methods:from this class:0
        //methods:from parent class(Employee):3
        private double Basic;
        private double DA;
        private double HRA;
        private double PF;
        private double PT;

        public override void display()
        {
            base.display();
            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("PF: " + PF);
            Console.WriteLine("PT: " + PT);
        }
        public new void check()
        {
            Console.WriteLine("This is check method from RegularEmployee class");
        }
    }
    class X : regularemployee
    {

    }
    internal class employee
    {
        public static void Run()
        {/*
            emp emp = new emp();
            emp.Name = "dhanani ramanshu";
            emp.Age = 20;
            emp.Dept = "IT";
            emp.serSalary(35000);
            emp.display();

            emp emp2 = new emp();
            emp2.Name = "agravat prem";
            emp2.Age = 20;
            emp2.Dept = "ce";
            emp2.serSalary(35000);
            emp2.display();*/

            emp emp3 = new emp();
            emp3.display();//employee
            emp3.check();//employee
            Console.WriteLine("--------------------------------------------------");


            regularemployee emp4 = new regularemployee();
            emp4.display();//regular employee
            emp4.check();//regular employee
            Console.WriteLine("--------------------------------------------------");

            emp emp5 = new regularemployee();
            emp5.display();//regularemployee
            emp5.check();//employee
            Console.WriteLine("--------------------------------------------------");

            Console.Read();
        }
    }
}