using System;

namespace _03_Ten_Minutes_Walk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] walk = Console.ReadLine().Split(",");
            Console.Write(string.Join(",", walk));
            Console.Write("---->");
            Console.WriteLine(Kata.IsValidWalk(walk));
        }
    }
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            int northSouth = 0;
            int eastWest = 0;
            int step = 0;
            bool isValid = false;
            for (int i = 0; i < walk.Length; i++)
            {
                if (walk[i] == "n")
                {
                    northSouth++;
                }
                else if (walk[i] == "s")
                {
                    northSouth--;
                }
                else if (walk[i] == "e")
                {
                    eastWest++;
                }
                else if (walk[i] == "w")
                {
                    eastWest--;
                }
                step++;

            }

            if (northSouth == 0 && eastWest == 0 && step == 10)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
