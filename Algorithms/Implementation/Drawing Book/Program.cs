using System;

namespace Drawing_Book
{
    public class Program
    {
        static int solve(int n, int p)
        {
            // Complete this function
            int pages = n / 2 +1;
            int turnedPagesFromStart = p / 2;
            int turnedPagesFromEnd = pages - turnedPagesFromStart - 1;
            int minTurnedPages = Math.Min(turnedPagesFromStart, turnedPagesFromEnd);
            return minTurnedPages;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int result = solve(n, p);
            Console.WriteLine(result);
        }
    }
}
