using System;

namespace Migratory_Birds
{
    public class Program
    {
        static int migratoryBirds(int n, int[] ar)
        {
            int result=0;
            int[] countArr = new int[6];
            // Complete this function
            for (int i = 0; i < n; i++)
            {
                switch (ar[i])
                {
                    case 1: countArr[1]++; break;
                    case 2: countArr[2]++; break;
                    case 3: countArr[3]++; break;
                    case 4: countArr[4]++; break;
                    case 5: countArr[5]++; break;
                    default: Console.WriteLine("Error!"); break;
                }
            }
            int maxCount = 0;
            for (int i = 1; i < countArr.Length; i++)
            {
                if (countArr[i]>maxCount)
                {
                    maxCount = countArr[i];
                    result = i;
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }
    }
}
