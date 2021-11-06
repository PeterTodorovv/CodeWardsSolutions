using System;

namespace replaceWithAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalText = Console.ReadLine();
            Console.WriteLine(AlphabetPosition(originalText));
        }

        public static string AlphabetPosition(string originalText)
        {
            string text = "";

            foreach(char chr in originalText.ToLower())
            {
                if (char.IsLetter(chr))
                {
                    text +=(int)chr - 96 + " ";
                }
            }

            return text.Trim();
        }
    }
}
