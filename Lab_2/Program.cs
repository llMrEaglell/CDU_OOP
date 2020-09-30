using System;
using System.Threading;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int m, n;
            m = 3;
            n = 2;
            int count = 1;
            double[,] arr = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = count;
                    count++;
                }
            }
            double[,] arr2 = new double[m-1, n];
            count = 1;
            for (int i = 0; i < m-1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[i, j] = count;
                    count++;
                }
            }
            MyMatrix a = new MyMatrix(arr);
            MyMatrix b = new MyMatrix(arr2);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a*b);

        }
    }
}