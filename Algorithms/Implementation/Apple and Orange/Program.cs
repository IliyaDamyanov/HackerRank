using System;

namespace Apple_and_Orange
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);
            ApplesFallenInTheHouse(s,t,a,b,apple,orange);
        }

        static void ApplesFallenInTheHouse(int houseStart, int houseEnd, int appleTree, int orangeTree, int[] apple, int[] orange)
        {
            int applesInTheHouse = 0;
            for (int i = 0; i < apple.Length; i++)
            {
                if (appleTree +apple[i]>=houseStart && appleTree + apple[i] <= houseEnd)
                {
                    applesInTheHouse++;
                }
            }

            int orangesInTheHouse = 0;
            for (int i = 0; i < orange.Length; i++)
            {
                if (orangeTree + orange[i] >= houseStart && orangeTree + orange[i] <= houseEnd)
                {
                    orangesInTheHouse++;
                }
            }
            Console.WriteLine(applesInTheHouse);
            Console.WriteLine(orangesInTheHouse);
        }
    }
}
