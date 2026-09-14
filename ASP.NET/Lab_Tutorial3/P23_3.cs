using System;

namespace ASP.NET.Lab_Tutorial3
{
    abstract class AccountP23
    {
        public double Amount;

        public AccountP23(double amount)
        {
            Amount = amount;
        }

        // Abstract method
        public abstract double CalculateInterest();
    }

    class SavingsAccountP23 : AccountP23
    {
        public SavingsAccountP23(double amount)
            : base(amount)
        {
        }

        public override double CalculateInterest()
        {
            return Amount * 5 / 100;
        }
    }

    class CurrentAccountP23 : AccountP23
    {
        public CurrentAccountP23(double amount)
            : base(amount)
        {
        }

        public override double CalculateInterest()
        {
            return Amount * 3 / 100;
        }
    }

    internal class P23_3
    {
        public static void Run()
        {
            SavingsAccountP23 savings = new SavingsAccountP23(10000);
            CurrentAccountP23 current = new CurrentAccountP23(10000);

            Console.WriteLine("Savings Account Interest: " +
                              savings.CalculateInterest());

            Console.WriteLine("Current Account Interest: " +
                              current.CalculateInterest());
        }
    }
}