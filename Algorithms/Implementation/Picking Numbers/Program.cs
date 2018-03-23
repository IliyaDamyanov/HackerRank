using System;

namespace Picking_Numbers
{
    public class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] countinArr = new int[101];
            for (int i = 0; i < n; i++)
            {
                countinArr[a[i]]++;
            }
            int maxInts = 0;
            for (int i = 0; i < countinArr.Length-1; i++)
            {
                if (countinArr[i]+countinArr[i+1]>maxInts)
                {
                    maxInts = countinArr[i] + countinArr[i + 1];
                }
            }
            Console.WriteLine(maxInts);
        }
    }
}
