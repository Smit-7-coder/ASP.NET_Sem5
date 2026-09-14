using System;

namespace ASP.NET.Lab_Tutorial3
{
   
    sealed class StudentResultP24
    {
        public int RollNo;
        public string Name;
        public int Marks;

        
        public StudentResultP24(int rollNo, string name, int marks)
        {
            RollNo = rollNo;
            Name = name;
            Marks = marks;
        }

       
        public void DisplayResult()
        {
            Console.WriteLine("Roll No: " + RollNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Marks: " + Marks);

            if (Marks >= 40)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
        }
    }

    internal class P24_3
    {
        public static void Run()
        {
            StudentResultP24 s = new StudentResultP24(101, "Smitigiri", 85);

            s.DisplayResult();
        }
    }
}