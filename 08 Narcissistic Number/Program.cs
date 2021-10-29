using System;

namespace _08_Narcissistic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Kata.Narcissistic(num));
        }
    }
    public class Kata
    {
        public static bool Narcissistic(int value)
        {
            string s = value.ToString();
            bool isNarc = false;
            int l = s.Length;
            double sum = 0;
            for (int i = 0; i < l; i++)
            {
                int powered = 1;
                for (int j = 1; j <= l; j++)
                {
                    powered *= int.Parse(s[i].ToString());
                }
                sum += powered;
            }
            if (sum == value)
            {
                isNarc = true;
            }
            return isNarc;
        }
    }
}
