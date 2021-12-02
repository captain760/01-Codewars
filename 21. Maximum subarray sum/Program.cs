using System;
using System.Linq;

namespace _21._Maximum_subarray_sum
{
    public static class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            //The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers
            int totalMaxSum = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
               
                int maxSum = int.MinValue;
                int currSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    currSum += arr[j];
                    if (currSum>maxSum)
                    {
                        
                        maxSum = currSum;

                    }
                }
                if (totalMaxSum<maxSum)
                {
                    totalMaxSum = maxSum;
                }
            }
            if (arr.Length>0)
            {
                return totalMaxSum;
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(Kata.MaxSequence(input));
        }
    }
}
