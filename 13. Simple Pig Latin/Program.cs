using System;
using System.Collections.Generic;
using System.Linq; 

namespace _13._Simple_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();
            Console.WriteLine(Kata.PigIt(msg));
        }
    }
    public class Kata
    {
        public static string PigIt(string str)
        {
            List<string> words = str.Split(" ").ToList();
            List<string> newWords = new List<string>();
            
            for (int i = 0; i < words.Count; i++)
            {
                string newWord = "";
                
                
                    for (int j = 1; j < words[i].Length; j++)
                    {
                        newWord += words[i][j].ToString();
                    }
                if (words[i].Length != 1 || words[i] == "a")
                {
                    newWord += words[i][0].ToString() + "ay";
                }
                else
                {
                    newWord = words[i];
                }
                newWords.Add(newWord);
            }
            str = string.Join(" ", newWords);
            return str;
        }
    }
}
