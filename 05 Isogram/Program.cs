using System;

namespace _05_Isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.Write(str);
            Console.Write("---->");
            Console.WriteLine(Kata.IsIsogram(str));
        }
    }
    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            
            bool notIso = false;
            if (str=="")
            {
                notIso = false;
            }
            else
            {
                for (int i = 0; i < str.Length-1; i++)
                {
                    for (int j = i+1; j < str.Length; j++)
                    {
                        if (str[i].ToString().Equals(str[j].ToString(), StringComparison.CurrentCultureIgnoreCase))
                        {
                            notIso = true;
                            break;
                            
                        }
                    }
                    if (notIso)
                    {
                        break;
                    }

                }
            }
            

           
            return !notIso;
        }
    }
}
