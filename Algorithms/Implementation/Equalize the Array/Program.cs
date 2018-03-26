using System;
using System.Collections.Generic;

namespace Equalize_the_Array
{
    public class Program
    {
        static int equalizeArray(int[] arr)
        {
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (numberCounts.ContainsKey(arr[i]))
                {
                    numberCounts[arr[i]]++;
                }
                else
                {
                    numberCounts.Add(arr[i], 1);
                }
            }
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (numberCounts[arr[i]] > numberCounts[arr[max]])
                {
                    max = i;
                }
            }

            return arr.Length - numberCounts[arr[max]];
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = equalizeArray(arr);
            Console.WriteLine(result);
        }
    }
}
