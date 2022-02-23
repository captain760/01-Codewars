using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            List<string> words = Console.ReadLine().Split(",").ToList();
            List<string> anaWords = new List<string>();
            anaWords = Kata.Anagrams(keyWord, words);
            Console.WriteLine(string.Join(",", anaWords));
        }
    }
    public static class Kata
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> anaWords = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                if (word.Length == words[i].Length)
                {
                    string currentWord = words[i];
                    for (int j = 0; j < word.Length; j++)
                    {

                        if (currentWord.Contains(word[j].ToString()))
                        {
                            currentWord = ChangeWord(currentWord, word[j]);
                        }
                    }
                    if (currentWord == "")
                    {
                        anaWords.Add(words[i]);
                    }
                }

            }

            return anaWords;
        }

        private static string ChangeWord(string currentWord, char v)
        {
            List<char> newWord = new List<char>();
            bool isFound = false;
            string reducedWord = "";
            for (int i = 0; i < currentWord.Length; i++)
            {
                if ((currentWord[i] != v) || isFound)
                {
                    newWord.Add(currentWord[i]);
                }
                else
                {

                    isFound = true;
                }
            }
            for (int i = 0; i < currentWord.Length - 1; i++)
            {
                reducedWord += newWord[i];
            }
            return reducedWord;
        }
    }
}
