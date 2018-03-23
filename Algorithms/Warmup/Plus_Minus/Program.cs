using System;

namespace Plus_Minus
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            double positive = 0;
            double negative = 0;
            double zeroes = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i]>0)
                {
                    positive++;
                }
                else if (arr[i] < 0)
                {
                    negative++;
                }
                else if(arr[i] == 0)
                {
                    zeroes++;
                }
            }
            positive = positive / n;
            negative = negative / n;
            zeroes = zeroes / n;
            Console.WriteLine("{0:F6}\n{1:F6}\n{2:F6}", positive,negative,zeroes);
        }
    }
}
