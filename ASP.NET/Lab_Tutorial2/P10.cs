using System;

namespace ASP.NET.Lab_Tutorial2
{
    internal class P10
    {
        static int matsearch(int[,] mat, int n, int m, int x)
        {
            int row = 0;
            int col = m - 1;

            while (row < n && col >= 0)
            {
                if (mat[row, col] == x)
                    return 1;
                else if (mat[row, col] > x)
                    col--;
                else
                    row++;
            }

            return 0;
        }

        public static void Run()
        {
            int[,] mat =
            {
                { 10, 20, 30 },
                { 15, 25, 35 },
                { 27, 29, 37 }
            };

            int result = matsearch(mat, 3, 3, 37);

            if (result == 1)
            {
                Console.WriteLine("Element is present in the matrix.");
            }
            else
            {
                Console.WriteLine("Element is not present in the matrix.");
            }

            Console.WriteLine("\n25SOEIT13027 SAKARIYA SMIT");
        }
    }
}