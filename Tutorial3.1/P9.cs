using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1___Tutorial
{
    internal class P9
    {
        class Library
        {
            public static string LibraryName = "City Library";

            public string BookName;

            public Library(string BookName)
            {
                this.BookName = BookName;
            }

            public void DisplayBook()
            {
                Console.WriteLine("Book Name: " + this.BookName);
            }
        }

        class OldLibrary : Library
        {
            public OldLibrary(string BookName) : base(BookName)
            {
            }

            public new void DisplayBook()
            {
                Console.WriteLine("New Book Name: " + BookName);
            }
        }

        public static void Program_9()
        {
            Console.WriteLine("Static Keyword:");
            Console.WriteLine("Library Name: " + Library.LibraryName);

            Console.WriteLine("\nthis Keyword:");
            Library book = new Library("C# Programming");
            book.DisplayBook();

            Console.WriteLine("\nbase Keyword:");
            OldLibrary oldBook = new OldLibrary("ASP.NET Programming");
            oldBook.DisplayBook();

            Console.WriteLine("\nnew Keyword:");
            oldBook.DisplayBook();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");


            Console.ReadLine();
        }
    }
}