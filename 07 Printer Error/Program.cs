using System;

namespace _07_Printer_Error
{
    class Program
    {
        static void Main(string[] args)
        {
            string controlStr = Console.ReadLine();
            Console.WriteLine($"printer_error(s) => {Printer.PrinterError(controlStr)}");
        }
    }
    public class Printer
    {
        public static string PrinterError(String s)
        {
            string colors = "abcdefghijklm";
            int errors = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < colors.Length; j++)

                    if (s[i] == colors[j])
                    {
                        errors++;
                    }
            }
            return ((s.Length - errors) + "/" + s.Length);
        }
    }
}
