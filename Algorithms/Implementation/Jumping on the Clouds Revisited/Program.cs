using System;

namespace Jumping_on_the_Clouds_Revisited
{
    class Program
    {
        static int jumpingOnClouds(int[] c, int k)
        {
            int position = 0;
            int energy = 100;
            do
            {
                position += k;
                if (position > c.Length - 1)
                {
                    position %= c.Length;
                }
                energy -= 1;
                if (c[position] == 1)
                {
                    energy -= 2;
                }
            } while (position != 0);
            return energy;
        }

        static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int result = jumpingOnClouds(c, k);
            Console.WriteLine(result);
        }
    }
}
