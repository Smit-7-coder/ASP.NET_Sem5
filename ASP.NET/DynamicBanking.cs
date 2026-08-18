using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    class BankAccounts
    {
        private int accNo;
        private string accHolderName;
        private double accBalance;
        private double amt;

        public void input()
        {
            
            Console.Write("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Holder Name: ");
           string accHolderName = Console.ReadLine();

            Console.WriteLine("Select Option To Perform");
            Console.WriteLine("1. Deposite Amount");
            Console.WriteLine("2. Withdraw Amount");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    Deposit(amt);
                    break;

                case 2:
                    Withdraw(amt);
                    
                    break;

                case 3:
                    BalanceInquery();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }


        }

        public void Deposit(double amount)
        {
            Console.WriteLine("Enter Ammount To Deposite: ");
            amount = Convert.ToDouble(Console.ReadLine());
            accBalance += amount;
            Console.WriteLine("Amount Deposited Successfully");

        }

        public void Withdraw(double amount)
        {
            Console.WriteLine("Enter Ammount To Withdraw: ");
            amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= accBalance)
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
            Console.WriteLine("Current Balance: " + accBalance);
        }
    }
    internal class DynamicBanking
    {
        public static void Run()
        {
            BankAccounts b = new BankAccounts();
            b.input();
        }
    }
}
