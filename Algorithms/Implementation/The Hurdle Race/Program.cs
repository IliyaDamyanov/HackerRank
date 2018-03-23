using System;

namespace The_Hurdle_Race
{
    public class Program
    {
        static int hurdleRace(int k, int[] height)
        {
            int max = 0;
            int minBevarages = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i]>max)
                {
                    max = height[i];
                }
            }
            if (max-k>0)
            {
                minBevarages = max - k;
            }
            return minBevarages;
        }

        static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);
            int result = hurdleRace(k, height);
            Console.WriteLine(result);
        }
    }
}
