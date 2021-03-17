using System;
using System.Threading;
using static System.Console;

namespace Lab7_1
{
    class Timer
    {
        private const int MilsecI = 1000;

        Action[] methods =
        {
            RandomNumber,
            CurrentTime,
            MonthDay
        };

        public void Start(int sec)
        {
            Random rand = new Random();
            while (true)
            {
                Thread.Sleep(sec * MilsecI);
                int a = rand.Next(0, 3);
                methods[a].Invoke();
            }
        }

        private static void MonthDay()
        {
            WriteLine("Mouth day: " + DateTime.Now.Day);
        }

        private static void CurrentTime()
        {
            WriteLine("Currnet time: " + DateTime.Now.TimeOfDay);
        }

        private static void RandomNumber()
        {
            Random rand = new Random();
            int a = rand.Next(0, 100);
            WriteLine("Random number: " + a);
        }
    }
}