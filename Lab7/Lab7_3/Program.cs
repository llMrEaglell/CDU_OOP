using static System.Console;

namespace Lab7_3
{
    class Program
    {
        private delegate void DivideOn(int[] mas);

        static void Main(string[] args)
        {
            int[] mas = {30, 1, 18, 45, 79, 65, 48, 31, 155, 165, 17, 7, 1, 3, 33, 11, 33, 77, 121, 171};
            DivideOn d3 = IfDividedOn3;
            DivideOn d7 = IfDividedOn7;
            d3.Invoke(mas);
            d7.Invoke(mas);
        }

        private static void IfDividedOn3(int[] mas)
        {
            WriteLine("Divide on 3: ");
            foreach (int a in mas)
                if (a % 3 == 0)
                {
                    Write(a + " ");
                }

            WriteLine();
        }

        private static void IfDividedOn7(int[] mas)
        {
            WriteLine("Divide on 7: ");
            foreach (int a in mas)
            {
                if (a % 7 == 0)
                {
                    Write(a + " ");
                }
            }

            WriteLine();
        }
    }
}