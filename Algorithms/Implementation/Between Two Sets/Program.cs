using System;

namespace Between_Two_Sets
{
    public class Program
    {
        static int getTotalX(int[] a, int[] b)
        {
            
            int result = 0;
            for (int i = a[a.Length-1]; i <= b[0]; i++)
            {
                bool proceed = false;
                for (int l = 0; l < a.Length; l++)
                {
                    if (i % a[l] != 0)
                    {
                        break;
                    }
                    else if (l == a.Length - 1 && i % a[l] == 0)
                    {
                        proceed = true;
                    }
                }
                if (proceed)
                {
                    for (int m = 0; m < b.Length; m++)
                    {
                        if (b[m] % i != 0)
                        {
                            break;
                        }
                        else if (m == b.Length - 1 && b[m] % i == 0)
                        {
                            result++;
                        }
                    }
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int total = getTotalX(a, b);
            Console.WriteLine(total);
        }
    }
}
