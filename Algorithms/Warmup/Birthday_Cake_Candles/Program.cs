using System;

namespace Birthday_Cake_Candles
{
    public class Program
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            // Complete this function
            int max = 0;
            int maxCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (ar[i] > max)
                {
                    maxCount = 1;
                    max = ar[i];
                }
                else if (ar[i]==max)
                {
                    maxCount++;
                }
            }
            return maxCount;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}
