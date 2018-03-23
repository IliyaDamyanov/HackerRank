using System;

namespace Angry_Professor
{
    public class Program
    {
        static string angryProfessor(int k, int[] a)
        {
            // Complete this function
            int studentsOnTime = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]<=0)
                {
                    studentsOnTime++;
                }
            }
            string IsTheClassCanceled = string.Empty;
            if (studentsOnTime<k)
            {
                IsTheClassCanceled = "YES";
            }
            else
            {
                IsTheClassCanceled = "NO";
            }
            return IsTheClassCanceled;
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                string result = angryProfessor(k, a);
                Console.WriteLine(result);
            }
        }
    }
}
