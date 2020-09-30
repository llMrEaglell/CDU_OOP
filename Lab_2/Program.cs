using System;
using System.Threading;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            m = 3;
            n = 2;
            double[,] arr = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = i;
                }
            }
            MyMatrix a = new MyMatrix(arr);
            Console.WriteLine(a);
            Console.WriteLine(a.GetTransponedCopy());
            Console.WriteLine(a);
            a.TransopnedMe();
            Console.WriteLine(a);
            a.TransopnedMe();
            Console.WriteLine(a);

        }
    }
}