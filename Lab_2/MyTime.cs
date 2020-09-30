using System;

namespace Lab_2
{
    public class MyTime
    {
        public int hour;
        public int minute;
        public int second;

        public MyTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public static int TimeSinceMidnight(MyTime t)
        {
            return 0;
        }

        public static MyTime TimeSinceMidnight(int t)
        {
            int secPerDay = 60 * 60 * 24;
            t = ((t % secPerDay) + secPerDay) % secPerDay;
            int h = t / 3600;
            int m = (t / 60) % 60;
            int s = t % 60;
            return new MyTime(h, m, s);

        }

        public static MyTime AddOneSecond(MyTime t)
        {
            return new MyTime(0, 0, 0);
        }

        public static MyTime AddOneMinute(MyTime t)
        {
            return new MyTime(0, 0, 0);
        }

        public static MyTime AddOneHour(MyTime t)
        {
            return new MyTime(0, 0, 0);
        }

        public static MyTime AddSeconds(MyTime t, int s)
        {
            return new MyTime(0, 0, 0);
        }

        public static int Difference(MyTime mt1, MyTime mt2)
        {
            return 0;
        }

        public static string WhatLesson(MyTime mt)
        {
            return "";
        }

        public override string ToString()
        {
            return String.Format("{00}:{01:00}:{02:00}", this.hour, this.minute, this.second);
        }
    }
}