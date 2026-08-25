using System;

namespace ASP.NET.Lab_Tutorial3
{
    
    public class calculate
    {
        public virtual void shape()
        {
            Console.WriteLine("Area of Shape");
        }
    }


    
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


    
    internal class P17_3
    {
        public static void Run()
        {
            calculate calculate;


            
            calculate = new circle();
            calculate.shape();

            Console.WriteLine();


            
            calculate = new Rectangle();
            calculate.shape();

            Console.WriteLine();


            
            calculate = new Triangle();
            calculate.shape();

            Console.ReadLine();
        }
    }
}