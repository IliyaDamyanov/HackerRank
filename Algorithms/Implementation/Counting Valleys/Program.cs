using System;

namespace Counting_Valleys
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string stepDenivelation = Console.ReadLine();
            bool isPrevMinusOne = false;
            int numberOfValleys = 0;
            int height = 0;
            for (int i = 0; i < n; i++)
            {
                if (stepDenivelation[i]=='U')
                {
                    height++;
                }
                else if (stepDenivelation[i] == 'D')
                {
                    height--;
                }
                if (height==-1)
                {
                    isPrevMinusOne = true;
                }
                else if (height==0 && isPrevMinusOne)
                {
                    numberOfValleys++;
                    isPrevMinusOne = false;
                }
            }
            Console.WriteLine(numberOfValleys);
        }
    }
}
