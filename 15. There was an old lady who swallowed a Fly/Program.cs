using System; 
using System.Collections.Generic;
using System.Linq;

namespace _15._There_was_an_old_lady_who_swallowed_a_Fly
{
    public class Dinglemouse
    {
        public static List<string> OldLadySwallows(List<string> animals)
        {
            List<string> line = new List<string>{ "fly", "spider", "bird", "cat", "dog", "goat", "cow", "horse" };
            if (animals.Contains("horse"))
            {
                int ind = animals.IndexOf("horse");
                animals.RemoveRange(ind + 1, animals.Count - ind - 1);
            }
            for (int i = 0; i < animals.Count; i++)
            {
                if (line.Contains(animals[i]))
                {
                    int index = line.IndexOf(animals[i]);
                    if (index == 7)
                    {
                        for (int j = i + 1; j < animals.Count; j++)
                        {
                            animals.RemoveAt(i + 1);
                            j--;
                        }
                        while (animals.Contains(line[6]))
                        {
                            animals.Remove(line[6]);
                        }
                        return animals;
                    }
                    else
                    {
                        List<string> currentList = new List<string>();
                        for (int j = 0; j <= i; j++)
                        {
                            currentList.Add(animals[j]);
                        }
                        if (index > 0 && currentList.Contains(line[index - 1]))
                        {

                            while (currentList.Contains(line[index - 1]))
                            {
                                animals.Remove(line[index - 1]);
                                currentList.Remove(line[index - 1]);
                                i--;
                            }
                        }

                        if (currentList.Contains(line[index + 1]))
                        {
                            string currAnimal = animals[i];
                            while (currentList.Contains(currAnimal))
                            {
                                animals.Remove(currAnimal);
                                currentList.Remove(currAnimal);
                                i--;
                            }
                        }
                    }
                }

            }
            return animals;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = Console.ReadLine().Split(", ").ToList();
            Dinglemouse.OldLadySwallows(animals);
            Console.WriteLine(string.Join(" ", animals));
         }
    }
}
