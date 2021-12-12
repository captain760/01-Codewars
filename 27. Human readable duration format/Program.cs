using System;

namespace _27._Human_readable_duration_format
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            string result = "";
            if (seconds == 0)
            {
                return "now";
            }
            else if (seconds<60)
            {
                if (seconds == 1)
                {
                    return "1 second";
                }
                return $"{seconds} seconds";
            }
            int[] arr = Figures(seconds);
            int lastNonZeroIndex = 4;
            if (arr[4] == 0)
            {
                lastNonZeroIndex = 3;
            }
            if (arr[4] == 0 && arr[3] == 0)
            {
                lastNonZeroIndex = 2;     
            }
            if (arr[4] == 0 && arr[3] == 0 & arr[2] == 0)
            {
                lastNonZeroIndex = 1;
            }
            if (arr[4] == 0 && arr[3] == 0 & arr[2] == 0 && arr[1] == 0)
            {
                lastNonZeroIndex = 0;
            }
            result = $"{(_ = arr[0] != 0 ? (arr[0].ToString()+" year"+(_=arr[0] ==1?null:"s")) : null)}{(_ = lastNonZeroIndex == 1 && arr[0] != 0 ? " and " :_=arr[0]!=0 && lastNonZeroIndex != 1 ? ", ":null)}{(_ = arr[1] != 0 ? (arr[1].ToString() + " day" + (_ = arr[1] == 1 ? null : "s")) : null)}{(_ = lastNonZeroIndex == 2 && arr[1] != 0 ? " and " : _ = arr[1] != 0 && lastNonZeroIndex!=2? ", " : null)}{(_ = arr[2] != 0 ? (arr[2].ToString() + " hour" + (_ = arr[2] == 1 ? null : "s")) : null)}{(_ = lastNonZeroIndex == 3 && arr[2] !=0 ? " and " : _ = arr[2] != 0 && lastNonZeroIndex!=3 ?", " : null)}{(_ = arr[3] != 0 ? (arr[3].ToString() + " minute" + (_ = arr[3] == 1 ? null : "s")) : null)}{(_ = lastNonZeroIndex == 4 && arr[3] != 0 ? " and " : null)}{(_ = arr[4] != 0 ? (arr[4].ToString() + " second" + (_ = arr[4] == 1 ? null : "s")) : null)}";


            return result;
        }
        private static int[] Figures(int seconds)
        {
            int[] array = new int[5];
            
                array[0] = seconds / 31536000;
                array[1] = (seconds % 31536000) / 86400;
                array[2] = ((seconds % 31536000) % 86400) / 3600;
                array[3] = (((seconds % 31536000) % 86400) % 3600) / 60;
                array[4] = ((((seconds % 31536000) % 86400) % 3600) % 60) % 60;
            
            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine(HumanTimeFormat.formatDuration(s));
        }
    }
}
