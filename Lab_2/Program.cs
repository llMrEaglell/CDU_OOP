using System;
using System.Threading;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "1 2 3 4\t4 5 6 7\t8 9 10 11\t12 13 14 15";
            MyMatrix matrix = new MyMatrix(a);
            
            Console.WriteLine(matrix);
            
        } 
    }
}