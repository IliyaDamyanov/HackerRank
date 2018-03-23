using System;

namespace Viral_Advertising
{
    public class Program
    {
        static int viralAdvertising(int n)
        {
            int peopleRecieved = 5;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                peopleRecieved /= 2;
                sum += peopleRecieved;
                peopleRecieved *= 3;
            }
            return sum;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = viralAdvertising(n);
            Console.WriteLine(result);
        }
    }
}
