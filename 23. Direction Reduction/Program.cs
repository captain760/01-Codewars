using System;
using System.Collections.Generic;

namespace _23._Direction_Reduction
{
    public class DirReduction
    {

        public static string[] dirReduc(String[] arr)
        {
            List<string> res = new List<string>();           
            foreach (var item in arr)
            {
                res.Add(item);
            }
            int counter = 0;
            while (counter < res.Count - 1)
            {


                bool oposite = false;
                if ((res[counter] == "NORTH" && res[counter + 1] == "SOUTH") || (res[counter] == "SOUTH" && res[counter + 1] == "NORTH") || (res[counter] == "EAST" && res[counter + 1] == "WEST") || (res[counter] == "WEST" && res[counter + 1] == "EAST"))
                {
                    oposite = true;
                }
                if (oposite)
                {
                    res.RemoveAt(counter);
                    res.RemoveAt(counter);
                    if (counter>0)
                    {
                        counter--;
                    }
                    continue;
                }
                counter++;
            }

            string[] b = new string[res.Count];
            int i = 0;
            foreach (var item in res)
            {
                b[i] = item;
                i++;
            }
            return b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            
            Console.WriteLine(string.Join(", ", DirReduction.dirReduc(a)));
            
        }
    }
}
