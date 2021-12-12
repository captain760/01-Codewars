using System;
using System.Collections.Generic;

namespace _29._First_Variation_on_Caesar_Cipher
{
    public class CaesarCipher
    {
        public static List<string> movingShift(string s, int shift)
        {
            string result = string.Empty;
            var parts = new List<string>();
            int devider = 0;
            for (int i = 0; i < s.Length; i++)
            {              
                if (s[i]>64 && s[i]<91)
                {
                    if ((char)(((shift + s[i] - 64) % 26) + 64) == '@')
                    {
                        result += 'Z';
                    }
                    else
                    {
                        result += (char)(((shift + s[i] - 64) % 26) + 64);
                    }
                }
                else if (s[i] > 96 && s[i] < 123)
                {

                    if ((char)(((shift + s[i] - 96) % 26) + 96) == '`')
                    {
                        result += 'z';
                    }
                    else
                    {
                        result += (char)(((shift + s[i] - 96) % 26) + 96);
                    }
                    
                }
                else
                {
                    result += s[i];
                }                
                shift++;
            }
            devider = (int)Math.Ceiling(1.0 * s.Length / 5);
            for (int i = 0; i < 5; i++)
            {

                if (i*devider<result.Length && i<4)
                {
                    parts.Add(result.Substring(i * devider, devider));
                }
                else
                {
                    parts.Add(result.Substring(i * devider));
                }
                
            }
            return parts;
        }

        public static string demovingShift(List<string> s, int shift)
        {
            string result = string.Empty;
            string answear = string.Empty;
            for (int i = 0; i < s.Count; i++)
            {
                result += s[i];
            }
            for (int i = 0; i < result.Length; i++)
            {
                int delta = shift;
                if (result[i] > 64 && result[i] < 91)
                {
                    
                    if ((result[i] - shift)<64)
                    {
                        delta = shift-26;
                        
                    }
                    
                        answear += (char)(result[i] - delta);
                    
                        
                    
                }
                else if (result[i] > 96 && result[i] < 123)
                {
                    if ((result[i] - shift) < 96)
                    {
                        delta = shift - 26;
                    }

                        answear += (char)(result[i] - delta);
                    
                }
                else
                {
                    answear += result[i];
                }
                shift++;
                if (shift>26)
                {
                    shift -= 26;
                }
            }

            return answear;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string u = "I should have known that you would have a perfect answer for me!!!"; 
            Console.WriteLine(CaesarCipher.demovingShift(CaesarCipher.movingShift(u, 1), 1));
        }
    }
}
