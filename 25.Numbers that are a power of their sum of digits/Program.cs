using System;
using System.Collections.Generic;
using System.Linq;

namespace _25.Numbers_that_are_a_power_of_their_sum_of_digits
{
    public class PowerSumDig
    {
        public static long PowerSumDigTerm(int n)
        {
            int index = 0;
            List<long> powers = new List<long>();
            List<long> sortedPowers = new List<long>();
            for (int j = 2; j <= 15; j++)
            {
                for (int i = 2; i <= 500; i++)
                {
                    powers.Add((long)Math.Pow(i, j));
                }
            }
            sortedPowers = powers.Distinct().OrderBy(x => x).ToList();

            long result = 81;
            int k = 0;
            while (index != n && k<sortedPowers.Count)
            {
                result = sortedPowers[k];
                    long res = result;
                    long sum = 0;
                    while (res != 0)
                    {
                        sum += res % 10;
                        res /= 10;
                    }
                    for (int l = 2; l < 15; l++)
                    {
                        if (Math.Pow(sum, l) == result)
                        {
                            index++;
                        }
                    }
                
                k++;
            }
            
                return result;
        }
        
    }


    //public static long Sum(long num) => num != 0 ? num % 10 + Sum(num / 10) : 0; -----namira sumata ot cifrite v num!!!




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerSumDig.PowerSumDigTerm(32));
        }
    }
}
