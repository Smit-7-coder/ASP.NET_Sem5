using System;

namespace ASP.NET.Lab_Tutorial3
{
    internal class P13_3
    {
        // Properties
        public string ProductName { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Property to calculate bill amount
        public double BillAmount
        {
            get
            {
                return Price * Quantity;
            }
        }

        public static void Run()
        {
            P13_3 product = new P13_3();

            // Accept product details
            Console.Write("Enter Product Name: ");
            product.ProductName = Console.ReadLine();

            Console.Write("Enter Price: ");
            product.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());

            // Display product details
            Console.WriteLine("\nProduct Details");
            Console.WriteLine("------------------------");
            Console.WriteLine("Product Name: " + product.ProductName);
            Console.WriteLine("Price: " + product.Price);
            Console.WriteLine("Quantity: " + product.Quantity);
            Console.WriteLine("Bill Amount: " + product.BillAmount);

            Console.ReadLine();
        }
    }
}