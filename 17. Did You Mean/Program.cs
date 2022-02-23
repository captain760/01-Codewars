using System;
using System.Collections.Generic;
using System.Linq;

namespace _17._Did_You_Mean
{


    public class Kata
    {
        private IEnumerable<string> words;

        public Kata(IEnumerable<string> words)
        {
            this.words = words;
        }

        public string FindMostSimilar(string term)
        {
            string orderedTyped = term.OrderBy(x => x).ToString();
            foreach (var word in words)
            {
                string orderedWord = word.OrderBy(x => x).ToString();
                int toAdd = orderedWord.Length - (orderedTyped.Intersect(orderedWord)).Count();
                int toRem = orderedTyped.Length - (orderedWord.Intersect(orderedTyped)).Count();
                //int toRep = 0;
                //if (toAdd ==orderedTyped.Length && toRem==orderedWord.Length)
                //{
                //    toRep = 
                //}
                Console.WriteLine(toRem);
                Console.WriteLine(toAdd);
            }
            return term;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata(new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" });
            string input = Console.ReadLine();
            Console.WriteLine(kata.FindMostSimilar(input));
        }
    }
}
