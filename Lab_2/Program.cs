using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int m, n;
            m = 10;
            n = 4;
            double[,] arr = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = i;
                }
            }
            MyMatrix a = new MyMatrix(arr);

            Console.WriteLine(a.Height);
            Console.WriteLine(a.Width);
        }
    }
}