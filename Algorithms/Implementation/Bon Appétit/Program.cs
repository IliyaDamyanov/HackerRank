using System;

namespace Bon_Appétit
{
    public class Program
    {
        static int? bonAppetit(int n, int k, int b, int[] ar)
        {
            int? result;
            int bill = 0;
            for (int i = 0; i < n; i++)
            {
                bill += ar[i];
            }
            bill -= ar[k];
            if (b-bill/2==0)
            {
                result = null;
            }
            else
            {
                result = b - bill/2;
            }
            return result;
        }

        static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int b = Convert.ToInt32(Console.ReadLine());
            int? result = bonAppetit(n, k, b, ar);
            if (result == null)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
