using System;

namespace Birthday_Chocolate
{
    public class Program
    {
        static int solve(int n, int[] s, int d, int m)
        {
            // Complete this function
            int result = 0;
            int chocolateSum;
            for (int i = 0; i <= n-m; i++)
            {
                chocolateSum = 0;
                for (int l = 0; l < m; l++)
                {
                    chocolateSum += s[i + l];
                }
                if (chocolateSum == d)
                {
                    result++;
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(n, s, d, m);
            Console.WriteLine(result);
        }
    }
}
