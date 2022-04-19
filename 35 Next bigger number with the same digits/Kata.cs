using System;
using System.Collections.Generic;
using System.Linq;

namespace _35_Next_bigger_number_with_the_same_digits
{
    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            string number = n.ToString();            
            long maxPossibleNumber = long.Parse(string.Join("", number.ToCharArray().OrderByDescending(x => x)));
            for (long i = n+1; i <= maxPossibleNumber; i++)
            {
                long nextNumberSorted = long.Parse(string.Join("", i.ToString().ToCharArray().OrderByDescending(x => x)));
                if (nextNumberSorted == maxPossibleNumber)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
