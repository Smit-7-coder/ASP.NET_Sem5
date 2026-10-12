using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1___Tutorial
{
    internal class P4
    {
        private int productCode;
        private string productName;
        private double price;

        public P4(int code, string name, double price)
        {
            productCode = code;
            productName = name;
            this.price = price;
        }

        public double CalculateDiscount()
        {
            return price * 0.10;
        }

        public double CalculateFinalPrice()
        {
            return price - CalculateDiscount();
        }

        public void Display()
        {
            Console.WriteLine("Product Code: " + productCode);
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Discount: " + CalculateDiscount());
            Console.WriteLine("Final Price: " + CalculateFinalPrice());
        }

       public static void Program_4()
        {
            P4 p = new P4(101, "Laptop", 50000);
            p.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");
        }
    }
}