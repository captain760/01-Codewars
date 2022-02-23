using System;

namespace _19.First_non_repeating_character
{
    public class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            string rest = "";
            int j = 0;
            bool isFound = false;
            for (int i = 0; i < s.Length; i++)
            {
                rest = s.Remove(i, 1).ToLower();
                if (!rest.Contains(s[i].ToString().ToLower()))
                {

                    j = i;
                    isFound = true;
                    break;
                }

            }
            if (isFound)
            {
                return s.Substring(j, 1);
            }
            else
            {
                return "";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Kata.FirstNonRepeatingLetter(input));
        }
    }
}
