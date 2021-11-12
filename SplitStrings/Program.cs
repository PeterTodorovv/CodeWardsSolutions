using System;
using System.Collections.Generic;

namespace SplitStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Solution(Console.ReadLine())));
        }

        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1) str += "_";
            List<string> pairs = new List<string>();

            for(int i = 0; i < str.Length; i+=2)
            {
                pairs.Add(str[i].ToString() + str[i+1]);
            }

            return pairs.ToArray();
        }
    }
}
