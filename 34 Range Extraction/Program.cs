using System;
using System.Text;

namespace _34_Range_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new[] { 1, 2, 3, 7,8,11,12,13, 18};
            int index = 1;
            var sb = new StringBuilder();
            if (inputArray.Length==0)
            {
                //return "";
            }
            if (inputArray.Length==1)
            {
                //return inputArray[0].ToString();
            }
            while (index <inputArray.Length)
            {
                int initialIndex = index - 1;
                while (index < inputArray.Length && inputArray[index-1]==inputArray[index]-1)
                {
                    index++;
                }
                if (initialIndex == index-1)
                {
                    if (index < inputArray.Length)
                    {
                        sb.Append($"{inputArray[index - 1]},");
                    }
                    else
                    {
                        sb.Append($"{inputArray[index - 1]}");
                    }
                }
                else if (initialIndex == index-2)
                {
                    if (index < inputArray.Length)
                    {
                        sb.Append($"{inputArray[initialIndex]},{inputArray[index - 1]},");
                    }
                    else
                    {
                        sb.Append($"{inputArray[initialIndex]},{inputArray[index - 1]}");
                    }
                    
                }
                else
                {
                    if (index<inputArray.Length)
                    {
                        sb.Append($"{inputArray[initialIndex]}-{inputArray[index - 1]},");
                    }
                    else
                    {
                        sb.Append($"{inputArray[initialIndex]}-{inputArray[index - 1]}");
                    }
                    
                }
                if (index == inputArray.Length-1)
                {
                    sb.Append($"{inputArray[index]}");
                }
                index++;
            }
            Console.WriteLine(sb.ToString());
            //return sb.ToString();
        }
    }
}
