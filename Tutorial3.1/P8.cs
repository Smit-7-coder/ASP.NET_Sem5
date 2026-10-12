using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1___Tutorial
{
    internal class P8
    {
        abstract class Payment
        {
            public abstract void CalculatePayment();
        }

        class CashPayment : Payment
        {
            public override void CalculatePayment()
            {
                Console.WriteLine("Cash Payment Amount: 5000");
            }
        }

        class OnlinePayment : Payment
        {
            public override void CalculatePayment()
            {
                Console.WriteLine("Online Payment Amount: 7500");
            }
        }

        public static void Program_8()
        {
            Payment cash = new CashPayment();
            Payment online = new OnlinePayment();

            cash.CalculatePayment();
            online.CalculatePayment();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");

            Console.ReadLine();
        }
    }
}