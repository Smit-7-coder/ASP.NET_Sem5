using System;

namespace ASP.NET.Lab_Tutorial3
{
    class PasswordP25
    {
        public string Password;

        public PasswordP25(string password)
        {
            Password = password;
        }

        public void ValidatePassword()
        {
            if (Password.Length >= 8)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. It must contain at least 8 characters.");
            }
        }

        public void ModifyPassword()
        {
            Password = Password.Trim();
            Password = Password.Replace(" ", "_");
            Password = Password.ToUpper();

            Console.WriteLine("Modified Password: " + Password);
        }
    }

    internal class P25_3
    {
        public static void Run()
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            PasswordP25 p = new PasswordP25(password);

            p.ValidatePassword();
            p.ModifyPassword();
        }
    }
}