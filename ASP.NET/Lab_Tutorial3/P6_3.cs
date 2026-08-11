using System;

namespace ASP.NET.Lab_Tutorial3

{

    public class P6_3

    {

        private double length;   // Length of a line

        public P6_3()

        {
            setLength(30);

            Console.WriteLine("Object Is Created Length: " + getLength());

        }



        public void setLength(double len)

        {
            length = len;

        }

        public double getLength()

        {

            return length;   

        }

    }



    public class TestLine

    {

        public static void Run()

        {

            P6_3 line = new P6_3();

            line.setLength(10);

            Console.WriteLine("Length of line : {0}", line.getLength());

            line.setLength(20);

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();

        }

    }

}