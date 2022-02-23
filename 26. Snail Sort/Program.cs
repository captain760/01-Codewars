using System;
using System.Linq;

namespace _26._Snail_Sort
{
    class Program
    {
        public class SnailSolution
        {
            public static int[] Snail(int[][] array)
            {
                int n = array[0].Length;
                if (n == 0)
                {
                    return new int[0];
                }
                int[] result = new int[array.Length * array.Length];
                int m = 0;
                int l = 0;
                int k = 0;

                while (k < array.Length * array.Length)
                {
                    for (int j = m; j < n - m - 1; j++)
                    {
                        result[k] = array[l][j];
                        k++;
                    }
                    for (int i = l; i < n - l; i++)
                    {
                        result[k] = array[i][n - m - 1];
                        k++;
                    }
                    for (int i = n - m - 2; i >= m; i--)
                    {
                        result[k] = array[n - l - 1][i];
                        k++;
                    }
                    for (int j = n - l - 2; j > l; j--)
                    {
                        result[k] = array[j][m];
                        k++;
                    }
                    m++;
                    l++;
                }

                return result;
            }
        }

        public static string Int2dToString(int[][] a)
        {
            return $"[{string.Join("\n", a.Select(row => $"[{string.Join(",", row)}]"))}]";
        }

        public static void Test(int[][] array, int[] result)
        {
            var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(", ", result)}]\n";
            Console.WriteLine(text);
            Console.WriteLine(string.Join(", ", SnailSolution.Snail(array)));
        }
        static void Main(string[] args)
        {
            int[][] array = new int[0][];
            // {
            //    new []{1, 2, 3, 4},
            //    new []{5, 6, 7, 8},
            //    new []{9, 10, 11, 12},
            //    new []{13, 14, 15, 16}
            //};
            //var r = new[] { 1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 };
            var r = new int[0];
            Test(array, r);
        }
    }
}
