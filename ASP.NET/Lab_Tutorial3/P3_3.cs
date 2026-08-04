using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial3
{
    class student
    {
        public int id;
        public string Name;

        public int Id
        {
            get { return id;  }
            set { id = value; }
        }

        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }

        public student()
        {
            id = 0;
            Name = "Unknown";
        }
        public student(int i, string n)
        {
            id = i;
            Name = n;
        }

        public void Display()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + Name);
        }
    }
    internal class P3_3
    {
        public static void Run()
        {
            student s1 = new student(101, "Smit");
            s1.Display();
        }
    }
}
