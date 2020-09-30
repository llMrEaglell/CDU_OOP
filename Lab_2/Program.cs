using System;
using System.Threading;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] a =
            {
                "5 6 7",
                "5 6 7",
                "5 6 7",
                "5 6 7 1"
            };
            Console.WriteLine(a.Length);
            MyMatrix matrix = new MyMatrix(a);
            
            Console.WriteLine(matrix);
            
        } 
    }
}