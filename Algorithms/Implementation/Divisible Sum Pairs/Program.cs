using System;

namespace Divisible_Sum_Pairs
{
    public class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            // Complete this function
            int result = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int l = i+1; l < n; l++)
                {
                    if ((ar[i] + ar[l])%k==0)
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
    }
}
