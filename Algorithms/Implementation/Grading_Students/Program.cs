using System;

namespace Grading_Students
{
    public class Program
    {
        static int[] solve(int[] grades)
        {
            // Complete this function
            int[] finalResults = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i]<38)
                {
                    finalResults[i] = grades[i];
                }
                else
                {
                    if (grades[i]%5>=3)
                    {
                        finalResults[i] = grades[i] + (5 - grades[i]%5);
                    }
                    else
                    {
                        finalResults[i] = grades[i];
                    }
                }
            }
            return finalResults;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = solve(grades);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
