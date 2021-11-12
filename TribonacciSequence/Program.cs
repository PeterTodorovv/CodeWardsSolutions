using System;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = {14, 11, 14};
            Console.WriteLine(string.Join(" ", Tribonacci(nums, 2)));
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] tribunacci = new double[n];
            if(n < 3)
            {
                for (int i = 0; i < n; i++)
                {
                    tribunacci[i] = signature[i];
                }
                return tribunacci;
            }
            for(int i = 0; i <= 2; i++)
            {
                tribunacci[i] = signature[i];
            }
            for(int i =  3; i < tribunacci.Length; i++)
            {
                tribunacci[i] = tribunacci[i - 1] + tribunacci[i - 2] + tribunacci[i - 3];
            }

            return tribunacci;
        }
    }
}
