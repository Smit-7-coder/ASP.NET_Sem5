using System;

namespace ASP.NET
{
    internal class ArmstrongNumber
    {
        public static void armstrong()
        {
            int number, temp, rem, sum = 0;

            Console.Write("Enter Number: ");
            string str = Console.ReadLine();

            number = Convert.ToInt32(str);
            temp = number;

            while (temp != 0)
            {
                rem = temp % 10;
                sum = sum + (rem * rem * rem);
                temp = temp / 10;
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is an Armstrong Number");
            }
            else
            {
                Console.WriteLine(number + " is not an Armstrong Number");
            }
        }
    }
}