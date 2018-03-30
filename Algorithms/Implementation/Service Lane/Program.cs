using System;

namespace Service_Lane
{
    public class Program
    {
        static int[] serviceLane(int[][] cases, int[] width)
        {
            int[] result = new int[cases.GetLength(0)];
            int resultIndex = 0;
            for (int i = 0; i < cases.GetLength(0); i++)
            {
                int startPoint = cases[i][0];
                int endPoint = cases[i][1];
                int min = width[startPoint];
                for (int j = startPoint + 1; j <= endPoint; j++)
                {
                    if (width[j] < min)
                    {
                        min = width[j];
                    }
                }
                result[resultIndex] = min;
                resultIndex++;
            }

            return result;
        }

        static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] width_temp = Console.ReadLine().Split(' ');
            int[] width = Array.ConvertAll(width_temp, Int32.Parse);
            int[][] cases = new int[t][];
            for (int cases_i = 0; cases_i < t; cases_i++)
            {
                string[] cases_temp = Console.ReadLine().Split(' ');
                cases[cases_i] = Array.ConvertAll(cases_temp, Int32.Parse);
            }
            int[] result = serviceLane(cases, width);
            Console.WriteLine(String.Join("\n", result));


        }
    }
}
