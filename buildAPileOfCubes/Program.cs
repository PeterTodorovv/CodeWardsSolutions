using System;

namespace buildAPileOfCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findNb(1071225));
        }

        public static long findNb(long m)
        {
            int n = 1;
            while(m > 0)
            {
                m -= (long)Math.Pow(n, 3);
                n++;
            }

            if (m == 0)
                return n -1;
            return -1;
        }
    }
}
