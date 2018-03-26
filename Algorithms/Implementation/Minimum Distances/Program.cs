using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Distances
{
    public class Program
    {
        //public static int minimumDistances(int[] a)
        //{
        //    HashSet<int> hashSet = new HashSet<int>();
        //    Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (dictionary.ContainsKey(a[i]))
        //        {
        //            dictionary[a[i]].Add(i);
        //        }
        //        else
        //        {
        //            dictionary.Add(a[i], new List<int>() { i });
        //        }
        //    }
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (dictionary[a[i]].Count>1)
        //        {

        //        }
        //    }

        //}

        //public static void FindMinDifferenceInEachSeparateList(ICollection<int> list, HashSet<int> hashSet)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {

        //    }
        //}

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
            HashSet<int> numbers = new HashSet<int>();
            HashSet<int> differences = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                numbers.Add(a[i]);
                for (int j = i + 1; j < a.Length - 1; j++)
                {
                    differences.Add(Math.Abs(a[i] - a[j]));
                }
            }
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                foreach (int item in differences)
                {
                    if (item<min)
                    {
                        min = item;
                    }
                }
            }

            return min;
        }
    }
}
