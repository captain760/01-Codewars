using System;

namespace _35_Next_bigger_number_with_the_same_digits
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine(Kata.NextBiggerNumber(513));
            Console.WriteLine(Kata.NextBiggerNumber(2017));
            Console.WriteLine(Kata.NextBiggerNumber(414));
            Console.WriteLine(Kata.NextBiggerNumber(144));
            Console.WriteLine(Kata.NextBiggerNumber(9));
            //Console.WriteLine(Kata.NextBiggerNumber(1111111999999999)); - no good - too slow algorithm....
        }
    }
}
