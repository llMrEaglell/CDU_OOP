using System;
using static System.Console;

namespace Lab_2_New
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteLine("Enter number 0, 1 or 2 for operations and number(Example: 0 7 or 1 3)\n" +
                      "0 -- sqrt(abs(x))\n" +
                      "1 -- x^3\n" +
                      "2 -- x + 3,5\n");
            int op;
            double num;

            while (true)
            {
                try
                {
                    string str = ReadLine();
                    string[] subs = str.Split(' ');
                    op = Convert.ToInt32(subs[0]);
                    num = Convert.ToDouble(subs[1]);

                    Action<double> oper;
                    if (op == 0)
                    {
                       oper = Root;
                       Operation(num, oper); 
                    } else if (op == 1)
                    {
                        oper = Triple;
                        Operation(num, oper);
                    } else if (op == 2)
                    {
                        oper = Addition;
                        Operation(num, oper);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    WriteLine("Input string was not in a correct format");
                    break;
                }
            }
        }

        private static void Operation(double x, Action<double> op)
        {
            op(x);
        }
        
        private static void Root(double x)
        {
            WriteLine(Math.Sqrt(Math.Abs(x)));
        }
        
        private static void Triple(double x)
        {
            WriteLine(Math.Pow(x, 3));
        }
        
        private static void Addition(double x)
        {
            WriteLine(x + 3.5);
        }
    }
}