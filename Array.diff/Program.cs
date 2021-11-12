using System;
using System.Collections.Generic;
using System.Linq;

namespace Array.diff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = {3};
            int[] ar2 = {1, 2, 3};
            Console.WriteLine(string.Join(" ", ArrayDiff(ar1, ar2)));
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}
