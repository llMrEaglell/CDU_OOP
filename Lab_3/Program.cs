using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle a = new Triangle(new Point(1,2), new Point(34, 5), new Point(5, 6));
            Console.WriteLine(a.a);
            Console.WriteLine(a.b);
            Console.WriteLine(a.c);
            Console.WriteLine(a.perimeter());
            Console.WriteLine(a.sqare());
        }
    }
}
