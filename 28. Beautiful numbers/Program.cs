using System;

namespace _28._Beautiful_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counter = 0;
            for (int a = 1; a < 4; a++)
            {
                for (int b = 1; b < 4; b++)
                {
                    for (int c = 1; c < 4; c++)
                    {
                        for (int d = 1; d < 4; d++)
                        {
                            for (int e = 1; e < 4; e++)
                            {
                                for (int f = 1; f < 4; f++)
                                {
                                    for (int g = 1; g < 4; g++)
                                    {
                                        for (int h = 1; h < 4; h++)
                                        {
                                            for (int j = 1; j < 4; j++)
                                            {
                                                for (int k = 1; k < 4; k++)
                                                {
                                                   
                                                        if (Math.Abs(a-b)==1 && Math.Abs(b - c) == 1 && Math.Abs(c - d) == 1 && Math.Abs(d - e) == 1 && Math.Abs(e - f) == 1 && Math.Abs(f - g) == 1 && Math.Abs(g - h) == 1 && Math.Abs(h - j) == 1 && Math.Abs(j - k) == 1)
                                                        {
                                                            counter++;
                                                            Console.WriteLine($"{counter} ==== {a}{b}{c}{d}{e}{f}{g}{h}{j}{k}");
                                                        }
                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
