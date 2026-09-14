using System;

namespace ASP.NET.Lab_Tutorial3
{
    class students
    {
        public int id;
        public string Name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }

        public students()
        {
            id = 0;
            Name = "Unknown";
        }

        public students(int i, string n)
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

    internal class P4_3
    {
        public static void Run()
        {
            // Creating objects for 5 students
            students s1 = new students(101, "Smitigiri");
            students s2 = new students(102, "Rahul");
            students s3 = new students(103, "Jeni");
            students s4 = new students(104, "Amit");
            students s5 = new students(105, "Priya");

            // Displaying students details
            s1.Display();
            Console.WriteLine();

            s2.Display();
            Console.WriteLine();

            s3.Display();
            Console.WriteLine();

            s4.Display();
            Console.WriteLine();

            s5.Display();
        }
    }
}