using System;
using System.Collections.Generic;
using System.Linq;

namespace Minimum_Distances
{
    public class Program
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = minimumDistances(a);
            Console.WriteLine(result);
        }

        static int minimumDistances(int[] a)
        {
            SortedSet<int> sortedList = new SortedSet<int>();
            int difference = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        difference = Math.Abs(j - i);
                        sortedList.Add(difference);
                    }
                }
            }
            if (sortedList.Count == 0)
            {
                return -1;
            }
            return sortedList.First();

        }
    }
}
