using System;
using System.Text.RegularExpressions;

namespace duplicateEncoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DuplicateEncode(Console.ReadLine()));
        }

        public static string DuplicateEncode(string word)
        {
            foreach (char chr in word)
            {
                word = word.ToLower();
                string element = chr.ToString();
                bool addedElements = false;
                if (element == ")" || element == "(")
                {
                    element = element.Insert(0, "\\");
                    addedElements = true;
                }
                if (Regex.Matches(word, element.ToString()).Count > 1)
                {
                    if(addedElements == true) element = element.Replace("\\", "");
                    addedElements = false;
                    word = word.Replace(element, ")");
                }
                else
                {
                    word = word.Replace(element, "(");
                }
            }
            return word;
        }
    }
}
