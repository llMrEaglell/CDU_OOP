using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            testAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
            WriteLine("\nDifference\n");
            testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
            testSquaresDifference(new MyComplex(1, 3), new MyComplex(1, 6));
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

        static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {

            WriteLine("=== Starting testing (a-b)=(a^2 - b^2)/(a+b) with a = " + a + ", b = " + b + " ===");
            WriteLine("a = " + a);
            WriteLine("b = " + b);
            WriteLine("(a - b) = " + a.Substract(b));
            WriteLine(" = = = ");
            T num = a.Multiply(a);
            WriteLine("a^2 = " + num);
            T bb = b.Multiply(b);
            WriteLine("b^2 = " + bb);
            num = num.Substract(bb);
            WriteLine("a^2 - b^2 = " + num);
            T denom = a.Add(b);
            WriteLine("a + b = " + denom);
            num = num.Devide(denom);
            WriteLine("(a^2 - b^2) / (a + b) = " + num);
            WriteLine("=== Finishing testing (a-b)=(a^2 - b^2)/(a+b) with a = " + a + ", b = " + b + " ===");

        }
    }
}