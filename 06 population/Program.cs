using System;

namespace _06_population
{
    class Program
    {
        static void Main(string[] args)
        {
            int p0 = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int aug = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(Arge.NbYear(p0, percent, aug, p));
        }
    }
    class Arge
    {

        public static int NbYear(int p0, double percent, int aug, int p)
        {

            int currentPop = p0;
            int years = 0;
            while (p >= currentPop)
            {
                years++;
                currentPop += (int)(currentPop * (percent / 100)) + aug;

            }
            return years;
        }
    }
}
