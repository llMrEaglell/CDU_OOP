using System;
using System.Threading;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTime a = new MyTime(4,5,20);
            Console.WriteLine(MyTime.TimeSinceMidnight(3605));
            
        } 
    }
}