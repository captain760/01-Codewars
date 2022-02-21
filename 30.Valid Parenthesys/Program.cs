using System;
using System.Collections.Generic;

namespace _30.Valid_Parenthesys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthesys = new Stack<char>();
            bool IsValid = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    parenthesys.Push(input[i]);
                }
                else if (input[i] == ')')
                {
                    if (parenthesys.Count > 0)
                    {
                        parenthesys.Pop();
                    }
                    else
                    {
                        IsValid = false;
                        break;
                    }
                }
            }
            if (parenthesys.Count>0)
            {
                IsValid = false;
            }
            Console.WriteLine(IsValid);
        }
    }
}
