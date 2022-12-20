using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheObservedPIN
{
    public class Kata
    {
        public static List<string> GetPINs(string observed)
        {
            Dictionary<string, int[]> possibleFigures = new Dictionary<string, int[]>
            {
                {"1",new[]{1,2,4}},
                {"2",new[]{1,2,3,5}},
                {"3",new[]{2,3,6}},
                {"4",new[]{1,4,5,7}},
                {"5",new[]{2,4,5,6,8}},
                {"6",new[]{3,5,6,9}},
                {"7",new[]{4,7,8}},
                {"8",new[]{0,5,7,8,9}},
                {"9",new[]{6,8,9}},
                {"0",new[]{0,8}}
            };
            
            int numbers = observed.Length;
            for (int i = 0; i < numbers; i++)
            {
                string symbol = observed[i].ToString();
                int currentFigure = int.Parse(symbol);
                List<int[]> result =
    GetPermutations(Enumerable.Range(1, 3), 3);
            }
           
        }
        private static List<int[]>
    GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

    }
}
