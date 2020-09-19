using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2
            try
            {
                TTriangle triangle = new TTriangle(10, 6, 8);
                Console.WriteLine(triangle.ToString());
                Console.WriteLine("Perimetr={0}",triangle.perimetr());
                Console.WriteLine("Square={0}",triangle.square());
            }
            catch (NullReferenceException e)
            {

            }
            catch
            {
                Console.WriteLine("Triangle does not exist ");
            }

            //Task 1
            Console.WriteLine("Input number of rows:");
            int rows = int.Parse(Console.ReadLine());
            int a, b;
            do
            {
                Console.WriteLine("Input start and end:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            } while (a > b);

            Random rand = new Random();
            int[][] toothedArray = new int[rows][];
        generate:
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                toothedArray[i] = new int[rand.Next(a, b)];
                count += toothedArray[i].Length;
            }

            Console.WriteLine("Count element's:" + count);
            if (!(Math.Sqrt(count) == Math.Truncate(Math.Sqrt(count))))
            {
                Console.WriteLine("The number of elements is not a square of a natural number\n" +
                                  "Press SPACE to generate new array");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                    goto generate;
            }

            foreach (var t in toothedArray)
            {
                for (int j = 0; j < t.Length; j++)
                    t[j] = rand.Next(100);
            }

            int[] simpleArray = new int[count];
            int counter = 0;
            foreach (int[] elem in toothedArray)
            {
                foreach (int num in elem)
                {
                    Console.Write("{0,4}", num);
                    simpleArray[counter] = num;
                    counter++;
                }

                Console.WriteLine();
            }

            Array.Sort(simpleArray);
            int size = (int)Math.Sqrt(count);
            int[,] quadArray = new int[size, size]; //квадратна
            counter = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    quadArray[i, j] = simpleArray[counter];
                    counter++;
                    Console.Write("{0:00} ", quadArray[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}