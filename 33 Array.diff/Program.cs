using System;
using System.Collections.Generic;
using System.Linq;

namespace _33_Array.diff
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2, 3, 4, 5, 6 };
            var b = new int[] { 1, 2, 2 };
            List<int> c = new List<int>();
            foreach (var item in a)
            {
                if (!b.Any(x=>x==item))
                {
                    c.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", c));
        }
    }
}
