using System;

namespace TakeATenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public static bool IsValidWalk(string[] walk)
        {
            int n = 0;
            int s = 0;
            int e = 0;
            int w = 0;

            foreach (string step in walk)
            {
                if (step == "n") n++;
                else if (step == "s") s++;
                else if (step == "e") e++;
                else if (step == "w") w++;
            }

            if (n == s && e == w && walk.Length == 10) return true;

            return false;
        }
    }
}
