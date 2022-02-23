using System;
using System.Collections.Generic;

namespace _22._Prime_factors
{
    public class PrimeDecomp
    {

        public static String factors(int lst)
        {
            Dictionary<int, int> primes = new Dictionary<int, int>();
            int val2 = 0;
            while (lst % 2 == 0)
            {
                lst /= 2;
                val2++;
            }
            if (val2 > 0)
            {
                primes.Add(2, val2);
            }


            for (int i = 3; i <= lst; i += 2)
            {
                //bool isPrime = true;
                int vali = 0;
                //for (int j = 3; j < Math.Sqrt(i); j++)
                //{
                //    if (i%j==0)
                //    {
                //        isPrime = false;
                //        break;
                //    }
                //}
                //if (!isPrime)
                //{
                //    continue;
                //}
                while (lst % i == 0)
                {
                    lst /= i;
                    vali++;
                }
                if (vali > 0)
                {
                    primes.Add(i, vali);
                }

            }


            string res = "";
            foreach (var item in primes)
            {
                if (item.Value == 1)
                {
                    res += $"({item.Key})";
                }
                else
                {
                    res += $"({item.Key}**{item.Value})";
                }
            }

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int lst = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimeDecomp.factors(lst));
        }
    }
}
