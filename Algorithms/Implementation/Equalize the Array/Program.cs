using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equalize_the_Array
{
    public class Program
    {
        static int equalizeArray(int[] arr)
        {
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (numberCounts.ContainsKey(arr[i]))
                {
                    numberCounts[arr[i]]++;
                }
                else
                {
                    numberCounts.Add(arr[i], 1);
                }
            }
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (numberCounts[arr[i]]> numberCounts[arr[max]])
                {
                    max = i;
                }
            }

            return arr.Length - numberCounts[arr[max]];
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string temp = "69 86 100 69 55 83 15 69 86 69 79 16 86 24 24 55 16 69 100 79 16 83 83 79 15 15 86 16 55 18 100 100 86 16 83 79 86 83 100 83 55 15 86 86 55 100 55 18 55 100 86 69 83 24 16 55 100 16 100 24 16 55 15 79 16 18 16 16 83 83 69 18 100 79 16 24 79 16 69 86 83 79 83 18 15 100 24 83";
            string[] arr_temp = temp.Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = equalizeArray(arr);
            Console.WriteLine(result);
        }
    }
}
