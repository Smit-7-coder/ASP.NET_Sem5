using System;

namespace _3._1___Tutorial
{
    internal class P5
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public P5(int bookID, string title, string author, double price)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Price = price;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Book ID: " + BookID);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("-------------------------");
        }

        public static void Program_5()
        {
            P5 book1 = new P5(101, "C# Programming", "John Smith", 450);
            P5 book2 = new P5(102, "Web Development", "David Miller", 550);
            P5 book3 = new P5(103, "Database Systems", "Robert Brown", 600);

            book1.DisplayDetails();
            book2.DisplayDetails();
            book3.DisplayDetails();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");

            Console.ReadLine();
        }
    }
}