using System;

namespace _02_isSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} => {Kata.IsSquare(n)}");

        }
    }
    public class Kata
    {
        public static bool IsSquare(int n)
        {
            bool isSqr = false;
            for (int i = 0; i < 44335; i++)
            {
                if (n == i * i)
                {
                    isSqr = true;
                    break;
                }
            }

            return isSqr;
        }
    }
}
