using System;
using System.Linq;

namespace _18._How_much_is_the_fish
{
    public class Kata
    {
        public static int FisHex(string name)
        {
            int hm = 0;
            char[] hexes = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F' };
            char[] hexesInWord = name.Where(c => hexes.Contains(c)).ToArray();
            string[] dec = new string[hexesInWord.Length];
            int[] decimals = new int[hexesInWord.Length];
            for (int i = 0; i < hexesInWord.Length; i++)
            {
                dec[i] = hexesInWord[i].ToString().ToLower();
                switch (dec[i])
                {
                    case "a":
                        {
                            decimals[i] = 10;
                            break;
                        }
                    case "b":
                        {
                            decimals[i] = 11;
                            break;
                        }
                    case "c":
                        {
                            decimals[i] = 12;
                            break;
                        }
                    case "d":
                        {
                            decimals[i] = 13;
                            break;
                        }
                    case "e":
                        {
                            decimals[i] = 14;
                            break;
                        }
                    case "f":
                        {
                            decimals[i] = 15;
                            break;
                        }

                    default:
                        break;
                }
            }
            if (decimals.Length > 0)
            {
                hm = decimals[0];
                for (int i = 1; i < decimals.Length; i++)
                {
                    hm ^= decimals[i];
                }
            }

            return hm;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Kata.FisHex(input));
        }
    }
}
