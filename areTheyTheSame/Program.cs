using System;
using System.Collections.Generic;

namespace areTheyTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {2, 2, 3 };
            int[] b = {4, 9, 9};
            Console.WriteLine(comp(a, b));
        }

        public static bool comp(int[] a, int[] b)
        {
            List<int> b2 = new List<int>(b);
            foreach(int element in a)
            {
                if (b2.Count < 1) return false;
                int powerdedNumber = (int)Math.Pow(element, 2);
                if (!b2.Contains(powerdedNumber))
                {
                    return false;
                }
                b2.Remove(powerdedNumber);
            }

            if (b2.Count > 0) return false;
            return true;
        }
    }
}
