using System;

namespace ASP.NET
{
    class TestRef
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x;   // Save x
            x = y;      // Put y into x
            y = temp;   // Put temp into y
        }
    }

    class P7
    {
        public static void Run()
        {
            TestRef obj = new TestRef();

            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            // Calling swap method
            obj.swap(ref a, ref b);

            Console.WriteLine("\nAfter swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadKey();
        }
    }
}