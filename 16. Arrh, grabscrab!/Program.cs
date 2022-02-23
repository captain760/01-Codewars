using System;
using System.Collections.Generic;
using System.Text;

namespace _16._Arrh__grabscrab_
{



    public static class Kata
    {
        public static List<string> Grabscrab(string anagram, List<string> dictionary)
        {
            List<string> result = new List<string>();
            foreach (var item in dictionary)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item);
                if (sb.Length == anagram.Length)
                {
                    foreach (var letter in anagram)
                    {
                        if (sb.ToString().Contains(letter))
                        {
                            sb.Remove(sb.ToString().IndexOf(letter), 1);
                        }
                    }
                    if (sb.Length == 0)
                    {
                        result.Add(item);
                    }
                }

            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dict = new List<string> { "donkey", "pool", "horse", "loop" };
            string anagram = Console.ReadLine();
            List<string> result = new List<string>();
            result = Kata.Grabscrab(anagram, dict);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
