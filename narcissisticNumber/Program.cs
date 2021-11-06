using System;

namespace narcissisticNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(int.Parse(Console.ReadLine())));
        }

        public static bool Narcissistic(int value)
        {
            double sum = 0;
            string number = value.ToString();

            foreach(char chr in number)
            {
                int num = int.Parse(chr.ToString());
                sum += Math.Pow(num, number.Length);
            }

            if(sum == int.Parse(number))
            {
                return true;
            }

            return false;
        }
    }
}
