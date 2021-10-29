using System;

namespace _12._Human_Readable_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine(TimeFormat.GetReadableTime(sec));
        }
    }
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {

            string h = "";
            string m = "";
            string s = "";
            int hrs = seconds / 3600;
            seconds = seconds - 3600 * hrs;
            int min = seconds / 60;
            seconds = seconds - 60 * min;
            if (hrs<10)
            {
                h = "0" + hrs;
            }
            else
            {
                h = hrs.ToString();
            }
            if (min < 10)
            {
                m = "0" + min;
            }
            else
            {
                m = min.ToString();
            }
            if (seconds < 10)
            {
                s = "0" + seconds;
            }
            else
            {
                s = seconds.ToString();
            }
            string hrt = h + ":" + m + ":" + s;
            return hrt;
        }
    }
}
