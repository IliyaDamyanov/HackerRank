using System;

namespace Mini_Max_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            long[] array = new long[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = Convert.ToInt64(arr[i]);
            }
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            long max = long.MinValue;
            long min = long.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (sum-array[i]>max)
                {
                    max = sum - arr[i];
                }
                if (sum- array[i] <min)
                {
                    min= sum - arr[i];
                }
            }
            Console.WriteLine($"{min} {max}");
        }
    }
}
