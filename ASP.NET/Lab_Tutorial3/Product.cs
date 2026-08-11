using System;

namespace ASP.NET

{

    class Product

    {
        int pcode;
        string pname;
        string mname;

        public Product(int pcd, string pnm, string mnm)

        {
            pcode = pcd;

            pname = pnm;

            mname = mnm;

        }



        public void Display()

        {

            Console.WriteLine("\nManufacturer Name:= " + mname);

          Console.WriteLine("\nProduct Code:= " + pcode);

          Console.WriteLine("\nProduct Name:= " + pname);
        }

    }

 

 

    public class TestProduct

    {

        public static void Run(string[] args)

        {

            int n = args.Length;



            if (n < 3)

            {

                Console.WriteLine("Syntax Error\n");

                Console.WriteLine("Must Have THREE Arguments\n");

                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");

            }

            else

            {



                int pcd = Convert.ToInt32(args[0]);

                String pnm = args[1];

                String mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);

                p.Display();

                Console.Read();



            }

        }

    }

}