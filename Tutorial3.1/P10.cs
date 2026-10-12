using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1___Tutorial
{
    internal class P10
    {
        class LibraryAccount
        {
            private int issuedBooks;

            public LibraryAccount()
            {
                issuedBooks = 0;
            }

            public void IssueBook()
            {
                issuedBooks++;
                Console.WriteLine("Book issued successfully.");
            }

            public void ReturnBook()
            {
                if (issuedBooks > 0)
                {
                    issuedBooks--;
                    Console.WriteLine("Book returned successfully.");
                }
                else
                {
                    Console.WriteLine("No books to return.");
                }
            }

            public void DisplayBooks()
            {
                Console.WriteLine("Issued Books: " + issuedBooks);
            }
        }

        public static void Program_10()
        {
            LibraryAccount account1 = new LibraryAccount();
            LibraryAccount account2 = new LibraryAccount();

            Console.WriteLine("Account 1:");
            account1.IssueBook();
            account1.IssueBook();
            account1.DisplayBooks();
            account1.ReturnBook();
            account1.DisplayBooks();

            Console.WriteLine("\nAccount 2:");
            account2.IssueBook();
            account2.DisplayBooks();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");

            Console.ReadLine();
        }
    }
}