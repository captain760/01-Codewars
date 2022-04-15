using System;
using System.Linq;

namespace _35_Next_bigger_number_with_the_same_digits
{
    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            char[] n1 = n.ToString().ToCharArray();
            Array.Sort(n1);
            string sortedNumberFirst = new string(n1);

                        
            while (true)
            {
                n++;
                char[] n2 = n.ToString().ToCharArray();
                Array.Sort(n2);
                string sortedNumberSecond = new string(n2);
                if (sortedNumberFirst.Length < sortedNumberSecond.Length)
                {
                    return -1;
                }
                                
                if (sortedNumberSecond == sortedNumberFirst)
                {
                    return n;
                }
                 
            }                        
        }
    }
}
