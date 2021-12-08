using System;
using System.Linq;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            List<long> powers = new List<long>();
            List<long> sortedPowers = new List<long>();
            for (int j = 3; j < 9; j++)
            {
                for (int i = 2; i < 171; i++)
                {
                    powers.Add((long)Math.Pow(i,j));
                }
            }
            sortedPowers = powers.Distinct().OrderBy(x=>x).ToList();
            //for (int l = 0; l < 50; l++)
            //{
            //    Console.WriteLine(sortedPowers[l]);
            //}
            for (long i = 81; i < 999999999999; i++)
            {
                if (sortedPowers.Contains(i))
                {
                    for (int l = 3; l < 9; l++)
                    {
                        if (Math.Pow(i,1/l)%1==0)
                        {
                            index++;
                        }
                    }
                }
            }
        }
    }
}
