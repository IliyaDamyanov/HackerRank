using System;

namespace Electronics_Shop
{
    public class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int s)
        {
            // Complete this function
            int maxPrice = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int l = 0; l < drives.Length; l++)
                {
                    if ((keyboards[i]+drives[l])>maxPrice && keyboards[i] + drives[l] <= s)
                    {
                        maxPrice = keyboards[i] + drives[l];
                    }
                }
            }
            if (maxPrice==0)
            {
                return -1;
            }
            else
            {
                return maxPrice;
            }
        }

        static void Main()
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int n = Convert.ToInt32(tokens_s[1]);
            int m = Convert.ToInt32(tokens_s[2]);
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
            string[] drives_temp = Console.ReadLine().Split(' ');
            int[] drives = Array.ConvertAll(drives_temp, Int32.Parse);
            //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
            int moneySpent = getMoneySpent(keyboards, drives, s);
            Console.WriteLine(moneySpent);
        }
    }
}
