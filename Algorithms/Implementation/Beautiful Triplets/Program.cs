using System;
using System.Linq;

namespace Beautiful_Triplets
{
    public class Program
    {
        static int beautifulTriplets(int d, int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Contains(arr[i] + d) && arr.Contains(arr[i] + 2 * d))
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = beautifulTriplets(d, arr);
            Console.WriteLine(result);
        }
    }
}
