using System;
using System.Collections.Generic;
using System.Linq;

namespace SimplePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Hello world !"));
        }

        public static string PigIt(string str)
        {
            List<string> words = str.Split().ToList();

            for(int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                if (word.Length > 1)
                {
                    char first = word[0];
                    word = word.Remove(0, 1);
                    word += first + "ay";
                    words[i] = word;
                }
            }
            return String.Join(" ", words);
        }
    }
}
