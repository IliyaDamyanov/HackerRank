using System;

namespace Diagonal_Difference
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int firstDiagonal = 0;
            for (int i = 0 , j = 0; i < n; i++, j++)
            {
                firstDiagonal += a[i][j];
            }
            int secondDiagonal = 0;
            for (int i = 0, j = n - 1; i <n; i++, j--)
            {
                secondDiagonal += a[i][j];
            }
            int result = Math.Abs(firstDiagonal - secondDiagonal);
            Console.WriteLine(result);
        }
    }
}
