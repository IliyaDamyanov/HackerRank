using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Distances
{
    public class Program
    {
        static int minimumDistances(int[] a)
        {
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
            for (int i = 0; i < a.Length; i++)
            {
                if (dictionary.ContainsKey(a[i]))
                {
                    dictionary[a[i]].Add(i);
                }
                else
                {
                    dictionary.Add(a[i], new List<int>() { i });
                }
            }

            

            for (int i = 0; i < a.Length; i++)
            {
                if (dictionary[a[i]].Count>1)
                {

                }
            }
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = minimumDistances(a);
            Console.WriteLine(result);
        }
    }
}
