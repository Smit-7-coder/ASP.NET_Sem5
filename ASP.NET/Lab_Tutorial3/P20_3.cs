using System;

namespace ASP.NET.Lab_Tutorial3
{
    class StudentP20
    {
        public int Id;
        public string Name;

       
        public StudentP20(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        
        public void Display()
        {
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Name: " + this.Name);
        }
    }

    internal class P20_3
    {
        public static void Run()
        {
            StudentP20 s = new StudentP20(101, "Smitigiri");

            s.Display();
        }
    }
}