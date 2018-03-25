using System;

namespace Jumping_on_the_Clouds
{
    public class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int counter = 0;
            if (c.Length == 2 || c.Length == 3)
            {
                return 1;
            }
            for (int i = 0; i < c.Length;)
            {
                if (c[i + 2] == 0)
                {
                    i += 2;
                    counter++;
                }
                else if (c[i + 1] == 0)
                {
                    i++;
                    counter++;
                }
                if (i == c.Length - 3 || i == c.Length - 2)
                {
                    counter++;
                    break;
                }
            }
            return counter;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int result = jumpingOnClouds(c);
            Console.WriteLine(result);
        }
    }
}
