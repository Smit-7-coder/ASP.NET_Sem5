using System;

public class P6
{
    public static void Run(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("You entered the following {0} command line arguments:",
            args.Length);

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Argument {0}: {1}", i + 1, args[i]);
        }

        Console.ReadKey();
    }
}