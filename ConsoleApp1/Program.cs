using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XO(Console.ReadLine().ToLower()));
        }

        public static bool XO(string input)
        {
            input = input.ToLower();
            return (input.Length - input.Replace("x", "").Length) == (input.Length - input.Replace("o", "").Length);
        }
    }
}
