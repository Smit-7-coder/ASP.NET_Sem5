using System;

namespace ASP.NET.Lab_Tutorial3
{
    // Base class
    public class calculate
    {
        public virtual void shape()
        {
            Console.WriteLine("Area of Shape");
        }
    }


    // Circle class
    class circle : calculate
    {
        public override void shape()
        {
            Console.Write("Enter radius of circle: ");

            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("Area of Circle = " + area);
        }
    }


    // Rectangle class
    class Rectangle : calculate
    {
        public override void shape()
        {
            Console.Write("Enter length of rectangle: ");

            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width of rectangle: ");

            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;

            Console.WriteLine("Area of Rectangle = " + area);
        }
    }


    // Triangle class
    class Triangle : calculate
    {
        public override void shape()
        {
            Console.Write("Enter base of triangle: ");

            double baseValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of triangle: ");

            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseValue * height;

            Console.WriteLine("Area of Triangle = " + area);
        }
    }


    // Main class
    internal class P17_3
    {
        public static void Run()
        {
            calculate calculate;


            // Circle
            calculate = new circle();
            calculate.shape();

            Console.WriteLine();


            // Rectangle
            calculate = new Rectangle();
            calculate.shape();

            Console.WriteLine();


            // Triangle
            calculate = new Triangle();
            calculate.shape();

            Console.ReadLine();
        }
    }
}