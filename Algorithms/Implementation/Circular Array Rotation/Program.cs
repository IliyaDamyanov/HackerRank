using System;
using System.Collections.Generic;

namespace Circular_Array_Rotation
{
    public class Program
    {
        static int[] circularArrayRotation(int[] a, int[] m, int k)
        {
            k = k % a.Length;
            int[] results = new int[m.Length];
            results[0] = a[a.Length - k];
            int afterMax = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a.Length - k +i<a.Length)
                {
                    results[i] = a[a.Length - k + i];
                }
                else
                {
                    results[i] = a[afterMax];
                    afterMax++;
                }
            }
            return results;
        }

        static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] m = new int[q];
            for (int m_i = 0; m_i < q; m_i++)
            {
                m[m_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = circularArrayRotation(a, m, k);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
