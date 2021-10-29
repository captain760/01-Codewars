using System;
namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Kata.Disemvowel(str);
            Console.WriteLine(str);
        }
        
    }
    public static class Kata
    {
        public static string Disemvowel(string str)
        {

            string newStr = str;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                    case 'o':
                    case 'e':
                    case 'i':
                    case 'u':
                        {
                            for (int k = 0; k < i; k++)
                            {
                                newStr += str[k];
                            }
                            for (int l = i + 1; l < str.Length; l++)
                            {
                                newStr += str[l];
                            }
                        }
                        break;
                    default:
                        break;
                }
                str = newStr;
            }

            return str;
        }
    }
}
