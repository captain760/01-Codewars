using System;

namespace _09_Budies_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let s(n) be the sum of these proper divisors of n.Call buddy two positive integers such that the sum of the proper divisors of each number is one more than the other number:
            //(n, m) are a pair of buddy if s(m) = n + 1 and s(n) = m + 1
            //            Divisors of 48 are: 1, 2, 3, 4, 6, 8, 12, 16, 24-- > sum: 76 = 75 + 1
            //            Divisors of 75 are: 1, 3, 5, 15, 25-- > sum: 49 = 48 + 1
            //Task
            //Given two positive integers start and limit, the function buddy(start, limit) should return the first pair(n m) of buddy pairs such that n(positive integer) is between start (inclusive)
            //and limit(inclusive); m can be greater than limit and has to be greater than n
            //If there is no buddy pair satisfying the conditions, then return "Nothing"
            int start = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine(Bud.Buddy(start, limit));

        }
    }
    class Bud
    {
        public static string Buddy(long start, long limit)
        {
            bool isPair = false;
            string pair = "";
            long summDivisors = 0;

            for (long m = start; m <= limit; m++)
            {
                for (long j = 2; j <= Math.Sqrt(m); j++)
                {
                    if (m % j == 0)
                    {
                        summDivisors += j;
                        if (m / j != j)
                        {
                            summDivisors += m / j;
                        }
                    }
                }
                summDivisors++;

                long n = summDivisors - 1;
                long sumnDivisors = 0;
                for (long k = 2; k <= Math.Sqrt(n); k++)
                {
                    if (n % k == 0)
                    {
                        sumnDivisors += k;
                        if (n / k != k)
                        {
                            sumnDivisors += n / k;
                        }
                    }
                }
                sumnDivisors++;

                if (sumnDivisors == m + 1 && m < n)
                {
                    pair = "(" + m.ToString() + " " + n.ToString() + ")";
                    isPair = true;
                    break;
                }

                summDivisors = 0;

            }
            if (isPair)
            {
                return pair;
            }
            return "Nothing";
        }
    }
}
