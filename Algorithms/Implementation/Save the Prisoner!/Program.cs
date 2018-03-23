using System;

namespace Save_the_Prisoner_
{
    public class Program
    {
        static int saveThePrisoner(int n, int m, int s)
        {
            if (s+m-1<=n)
            {
                return s + m - 1;
            }
            else
            {
                if ((s + m - 1) % n ==0)
                {
                    return n;
                }
                else
                {
                    return (s + m -1 ) % n;
                }
            }
        }

        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int m = Convert.ToInt32(tokens_n[1]);
                int s = Convert.ToInt32(tokens_n[2]);
                int result = saveThePrisoner(n, m, s);
                Console.WriteLine(result);
            }
        }
    }
}
