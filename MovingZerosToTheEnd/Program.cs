using System;
using System.Collections.Generic;

namespace MovingZerosToTheEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            Console.WriteLine(string.Join(" ", MoveZeroes(array)));
        }

        public static int[] MoveZeroes(int[] arr)
        {
            int[] newArray = new int[arr.Length];
            int indexesBehind = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    newArray[i-indexesBehind] = arr[i];
                }
                else
                {
                    indexesBehind++;
                }
                
            }

            return newArray;
        }
    }
}
