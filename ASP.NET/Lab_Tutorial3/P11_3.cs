using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial3
{
    class BankAccounts
    {
        private int accNo;
        private string accHolderName;
        private double accBalance;

        public BankAccounts(int accNo, string accHolderName, double accBalance)
        {
            this.accNo = accNo;
            this.accHolderName = accHolderName;
            this.accBalance = accBalance;
        }

        public void Deposit(double amount)
        {
            accBalance += amount;
            Console.WriteLine("Amount Deposited Successfully");

        }

        public void Withdraw(double amount)
        {
            if(amount <= accBalance)
            {
                accBalance -= amount;
                Console.WriteLine("Withdrawed Successfully");
            }
            else
            {
                Console.WriteLine("Insufficent Balance");
            }
        }

        public void BalanceInquery()
        {
            Console.WriteLine("================Balance Enquery================");
            Console.WriteLine("Account Number: " + accNo);
            Console.WriteLine("Account Holder Name: " + accHolderName);
            Console.WriteLine("Current Balance: "+accBalance);
        }
    }
    internal class P11_3
    {
        public static void Run()
        {
            BankAccounts b = new BankAccounts(1001,"Smit",50000);
            b.Deposit(10000);
            b.Withdraw(3000);
            b.BalanceInquery();
        }
    }
}
