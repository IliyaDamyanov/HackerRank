using System;

namespace Sock_Merchant
{
    public class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            // Complete this function
            int[] countingArr = new int[101];
            for (int i = 0; i < n; i++)
            {
                countingArr[ar[i]]++;
            }
            int pairs = 0;
            for (int i = 1; i < countingArr.Length; i++)
            {
                pairs += countingArr[i] / 2;
            }
            return pairs;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
    }
}
