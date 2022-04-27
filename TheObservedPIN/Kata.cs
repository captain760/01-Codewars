using System;
using System.Collections.Generic;
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
            List<string> result = new List<string>();
            int numbers = observed.Length;
            for (int i = 0; i < numbers; i++)
            {
                string symbol = observed[i].ToString();
                int currentFigure = int.Parse(symbol);
            }

            return null;
        }
    }
}
