using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forming_a_Magic_Square
{
    public class Program
    {
        static int formingMagicSquare(int[][] s)
        {
            int mostCommonSum = FindingMostCommonSum(s);
            int change = 0;
            // Complete this function
            for (int row = 0; row < 3; row++)
            {
                int rowSum = 0;
                int colSum = 0;
                int diagonalSum = 0;
                for (int col = 0; col < 3; col++)
                {
                    rowSum += s[row][col];
                }
                if (rowSum==mostCommonSum)
                {
                    continue;
                }
                else
                {
                    for (int col2 = 0; col2 < 3; col2++)
                    {
                        for (int row2 = 0; row2 < 3; row2++)
                        {
                            colSum+= s[row2][col2];
                        }
                        if (colSum==mostCommonSum)
                        {
                            continue;
                        }
                        else
                        {
                            int currentChange = Math.Abs(mostCommonSum - colSum);
                            change += currentChange;
                            s[row][col2] += (mostCommonSum - colSum);
                        }
                    }
                }
            }
            return change;
        }

        static void Main(String[] args)
        {
            int[][] s = new int[3][];
            for (int s_i = 0; s_i < 3; s_i++)
            {
                string[] s_temp = Console.ReadLine().Split(' ');
                s[s_i] = Array.ConvertAll(s_temp, Int32.Parse);
            }
            int result = formingMagicSquare(s);
            Console.WriteLine(result);
        }

        static int FindingMostCommonSum(int[][] s)
        {
            int[] countingArr = new int[28];
            for (int row = 0; row < 3; row++)
            {
                int sum = 0;
                for (int col = 0; col < 3; col++)
                {
                    sum += s[row][col];
                }
                countingArr[sum]++;
            }
            for (int col = 0; col < 3; col++)
            {
                int sum = 0;
                for (int row = 0; row < 3; row++)
                {
                    sum += s[row][col];
                }
                countingArr[sum]++;
            }
            countingArr[s[0][0] + s[1][1] + s[2][2]]++;
            countingArr[s[0][3] + s[1][1] + s[3][0]]++;
            int maxCount = 0;
            int mostCommonSum =0 ;
            for (int i = 3; i < countingArr.Length; i++)
            {
                if (countingArr[i]>maxCount)
                {
                    maxCount = countingArr[i];
                    mostCommonSum = i;
                }
            }
            return mostCommonSum;
        }
    }
}
