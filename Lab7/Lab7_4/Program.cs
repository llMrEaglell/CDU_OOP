using static System.Console;

namespace Task4
{
    class Program
    {
        public delegate void Delegate(int n);

        static void Main(string[] args)
        {
            Write("Enter the accuracy: ");
            int n = int.Parse(ReadLine());
            Delegate del1 = new Delegate(Type1);
            del1.Invoke(n);
            Delegate del2 = new Delegate(Type2);
            del2.Invoke(n);
            Delegate del3 = new Delegate(Type3);
            del3.Invoke(n);
        }

        public static void Type1(int n)
        {
            double output = 0;
            int bottom = 1;
            for (int i = 1; i <= n; i++)
            {
                output += 1.0 / bottom;
                bottom *= 2;
            }

            WriteLine("The result of the calculation according to the first formula: " + output);
        }

        public static void Type2(int n)
        {
            double output = 0;
            for (int i = 1; i <= n; i++)
            {
                output += 1.0 / Factorial(i);
            }

            WriteLine("The result of the calculation according to the second formula: " + output);
        }

        public static void Type3(int n)
        {
            double output = 1;
            int bottom = 1;
            if (n % 2 == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    bottom *= 2;
                    output += 1.0 / bottom;
                    bottom *= 2;
                    output -= 1.0 / bottom;
                }
            }
            else
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    bottom *= 2;
                    output += 1.0 / bottom;
                    bottom *= 2;
                    output -= 1.0 / bottom;
                }

                output += 1.0 / bottom;
            }

            WriteLine("The result of the calculation according to the third formula: " + output);
        }

        public static int Factorial(int b)
        {
            int res = 1;
            for (int i = 1; i <= b; i++)
            {
                res *= i;
            }

            return res;
        }
    }
}