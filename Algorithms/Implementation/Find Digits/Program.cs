using System;

namespace Find_Digits
{
    class Program
    {
        static int findDigits(int n)
        {
            int i = 10;
            int counter = 0;
            while (n / (i / 10) != 0)
            {
                int remainder = (n % i) / (i / 10);

                i *= 10;
                if (remainder == 0)
                {
                    continue;
                }
                else if (n % remainder == 0)
                {
                    counter += 1;
                }
            }
            return counter;
        }

        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int result = findDigits(n);
                Console.WriteLine(result);
            }
        }
    }
}
