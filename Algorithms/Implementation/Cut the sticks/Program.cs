using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cut_the_sticks
{
    public class Program
    {
        static int[] CutTheSticks(int[] arr)
        {
            List<int> result = new List<int>();
            List<int> list = new List<int>();
            result.Add(arr.Length);
            list = arr.ToList();
            while (true)
            {
                int minPosition = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < list[minPosition] && list[i] > 0)
                    {
                        minPosition = i;
                    }
                }
                int currentMin = list[minPosition];
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] -= currentMin;
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= 0)
                    {
                        list.Remove(list[i]);
                        i--;
                    }
                }
                if (list.Count==0)
                {
                    break;
                }
                result.Add(list.Count);
            }
            return result.ToArray();
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] result = CutTheSticks(arr);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
