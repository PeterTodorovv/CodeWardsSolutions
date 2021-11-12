using System;

namespace EqualSidesOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 100, 50, -51, 1};
            Console.WriteLine(FindEvenIndex(arr));
        }

        public static int FindEvenIndex(int[] arr)
        {

            for(int i = 0; i < arr.Length; i++)
            {
                int leftsideSum = 0;
                int rightsideSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftsideSum += arr[k];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightsideSum += arr[k];
                }
                if(leftsideSum == rightsideSum)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
