using System;
using System.Numerics;

namespace Extra_Long_Factorials
{
    class Program
    {
        static void extraLongFactorials(int n)
        {
            BigInteger result = 1;
            if (n == 0 || n == 1)
            {
                result = 1;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
            }
            Console.WriteLine(result);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            extraLongFactorials(n);
        }
    }
}
