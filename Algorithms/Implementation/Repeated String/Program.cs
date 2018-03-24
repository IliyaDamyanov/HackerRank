using System;

namespace Repeated_String
{
    public class Program
    {
        static long repeatedString(string s, long n)
        {
            int numberOfAInString = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    numberOfAInString++;
                }
            }
            long multiplier = n / s.Length;
            long finalNumberOfA = numberOfAInString * multiplier;
            long remainder = n % s.Length;
            int numberOfAToAdd = 0;
            for (int i = 0; i < remainder; i++)
            {
                if (s[i] == 'a')
                {
                    numberOfAToAdd++;
                }
            }
            finalNumberOfA += numberOfAToAdd;
            return finalNumberOfA;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            long result = repeatedString(s, n);
            Console.WriteLine(result);
        }
    }
}
