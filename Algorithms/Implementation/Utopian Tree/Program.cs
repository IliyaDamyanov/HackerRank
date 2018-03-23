using System;

namespace Utopian_Tree
{
    public class Program
    {
        static int utopianTree(int n)
        {
            // Complete this function
            int height = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    height *= 2;
                }
                else if (i%2==1)
                {
                    height += 1;
                }
            }
            return height;
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int result = utopianTree(n);
                Console.WriteLine(result);
            }
        }
    }
}
