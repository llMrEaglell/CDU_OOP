using System;
using System.Threading;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTime a = new MyTime(22,60,60);
            Console.WriteLine(MyTime.TimeSinceMidnight(2262));
            Console.WriteLine(MyTime.TimeSinceMidnight(a));
            Console.WriteLine(MyTime.AddOneSecond(a));
        } 
    }
}