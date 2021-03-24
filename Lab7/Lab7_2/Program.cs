using static System.Console;

namespace Lab7_2
{
    class Program
    {
        delegate void TimerExecutor(int sec);

        static void Main(string[] args)
        {
            Write("Enter count of seconds: ");
            int sec = int.Parse(ReadLine());
            Timer timer = new Timer();
            TimerExecutor del = timer.Start;
            del.Invoke(sec);
        }
    }
}