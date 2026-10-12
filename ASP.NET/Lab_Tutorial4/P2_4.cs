using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial4
{
    //Base class or Parent class.

    class Shape

    {

        public double Width;

        public double Height;

        public void ShowDim()

        {

            Console.WriteLine("Width and height are " + Width + " and " + Height);

        }

    }

    // Triangle is derived from Shape.

    //Drived class or Child class.

    class Triangle : Shape

    {

        public string Style; // style of triangle

    // Return area of triangle.

 //………………………………Missing statement-1……………………………….//
 
            public double Area()

            {

                return Width * Height / 2;

            }

        // Display a triangle's style.

        public void ShowStyle()

        {

            Console.WriteLine(Style);    

        }

    }

    //Driver class which runs the program.

    internal class P2_4

    {

        public static void Run()

        {

            Triangle t1 = new Triangle();

            Triangle t2 = new Triangle();



            t1.Width = 4.0;

            t1.Height = 4.0;

            t1.Style = "isosceles";

            t2.Width = 8.0;

            t2.Height = 12.0;

            t2.Style = "right";



            Console.WriteLine("Info for t1: ");

            t1.ShowStyle();

            t1.ShowDim();

            Console.WriteLine("Area is " + t1.Area());



            Console.WriteLine();



            Console.WriteLine("Info for t2: ");

            t2.ShowStyle();

            t2.ShowDim();

            Console.WriteLine("Area is " + t2.Area());

        }

    }
}
