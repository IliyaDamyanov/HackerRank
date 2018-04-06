using System;

namespace Sequence_Equation
{
    public class Program
    {
        static int[] permutationEquation(int[] p, int n)
        {
            int[] result = new int[p.Length];
            int p_index = 0;
            int resultIndex = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j] == i)
                    {
                        p_index = j + 1;
                        break;
                    }
                }
                for (int k = 0; k < p.Length; k++)
                {
                    if (p[k] == p_index)
                    {
                        result[resultIndex] = k + 1;
                        resultIndex++;
                        break;
                    }
                }
            }
            return result;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] p_temp = Console.ReadLine().Split(' ');
            int[] p = Array.ConvertAll(p_temp, Int32.Parse);
            int[] result = permutationEquation(p, n);
            Console.WriteLine(String.Join("\n", result));


        }
    }
}
