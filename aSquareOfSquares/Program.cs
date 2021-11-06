using System;

namespace aSquareOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSquare(int.Parse(Console.ReadLine())));
        }

        public static bool IsSquare(int n)
        {
            if (Math.Sqrt(n) == (int)Math.Sqrt(n)) return true;
            return false;
        }
    }
}
