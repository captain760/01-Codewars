using System;
using System.Collections.Generic;

namespace _24._Move_all_zeroes_to_the_end
{
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> list = new List<int>();
            list.AddRange(arr);
            int j = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (list[i] == 0)
                {
                    list.RemoveAt(i);
                    list.Add(0);
                    if (list[i] == 0)
                    {
                        i--;
                    }
                }
                j--;
                if (j == 0)
                {
                    break;
                }
            }
            return list.ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.  
            Console.WriteLine(string.Join(", ", Kata.MoveZeroes(new int[] { 1, 0, 0, 0, 0, 1, 0, 3, 0, 1 })));
        }
    }
}
