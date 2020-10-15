using System;
using System.Threading;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] doubles = new double[5,5];
            for (var i = 0; i < 5; i++)
            {
                for (var i1 = 0; i1 < 5; i1++)
                {
                    doubles[i, i1] = i;
                }
            }
            MyMatrix testMatrix = new MyMatrix(doubles);
            Console.WriteLine(testMatrix);
        } 
    }
}