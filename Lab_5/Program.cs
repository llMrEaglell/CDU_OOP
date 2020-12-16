using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            testAPlusBSquare(new Frac(1, 3), new Frac(1, 6));
            testAPlusBSquare(new Complex(1, 3), new Complex(1, 6));
        }
        static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            WriteLine($"=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = {a}, b = {b} ===");
            T aPlusB = a.Add(b);
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"(a + b) = {aPlusB}");
            WriteLine($"(a+b)^2 = {aPlusB.Multiply(aPlusB)}");
            WriteLine(" = = = ");
            T curr = a.Multiply(a);
            WriteLine($"a^2 = {curr}");
            T wholeRightPart = curr;
            curr = a.Multiply(b); // ab
            curr = curr.Add(curr); // ab + ab = 2ab
            // I’m not sure how to create constant factor "2" in more elegant way,
            // without knowing how IMyNumber is implemented
            WriteLine($"2*a*b = {curr}");
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            WriteLine($"b^2 = {curr}");
            wholeRightPart = wholeRightPart.Add(curr);
            WriteLine($"a^2+2ab+b^2 = {wholeRightPart}");
            WriteLine($"=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = {a}, b = {b} ===");
        }
    }
}