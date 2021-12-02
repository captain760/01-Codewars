using System;
using System.Collections.Generic;
using System.Linq;

namespace _20.Hamming_Numbers
{
    public class Hamming
    {
        public static long hamming(int n)
        {
            //int i = 0;
            //int j = 0;
            //int k = 0;
            //long[] res = new long[n];
            //res[0]=1;  
            //long x2 = 2, x3 = 3, x5 = 5;
            //for (int index = 1; index < n; index++)
            //{
            //    res[index] = Math.Min(x2, Math.Min(x3, x5));
            //    if (res[index] == x2) x2 = 2 * res[++i];
            //    if (res[index] == x3) x3 = 3 * res[++j];
            //    if (res[index] == x5) x5 = 5 * res[++k];
            //}
            //return res[n-1];
            var next = new SortedSet<long>();
            next.Add(1);

            for (int i = 1; i < n; i++)
            {
                var hamming = next.First();
                next.Remove(hamming);
                next.Add(hamming * 2);
                next.Add(hamming * 3);
                next.Add(hamming * 5);
            }

            return next.First();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Hamming.hamming(n));
        }
    }
}
