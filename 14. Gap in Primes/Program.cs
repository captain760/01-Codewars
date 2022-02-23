using System;
using System.Collections.Generic;

namespace _14._Gap_in_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long[] rez = new long[2];
            rez = GapInPrimes.Gap(g, m, n);
            Console.WriteLine($"[{rez[0]},{rez[1]}]");
        }
    }
    class GapInPrimes
    {
        public static long[] Gap(int g, int m, int n)
        {
            long[] rez = new long[2];
            List<long> primes = new List<long>();
            bool isNotPrime = false;
            for (int i = m; i <= n; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                }
                if (!isNotPrime)
                {
                    primes.Add(i);
                }
                isNotPrime = false;
            }
            //Console.WriteLine(string.Join(",", primes));
            for (int i = 0; i < primes.Count - 1; i++)
            {
                if ((primes[i + 1] - primes[i]) == g)
                {
                    rez[0] = primes[i];
                    rez[1] = primes[i + 1];
                    return rez;
                }
            }

            return rez;
        }
    }
}
