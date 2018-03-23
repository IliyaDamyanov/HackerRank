using System;

namespace Breaking_the_Records
{
    public class Program
    {
        static int[] getRecord(int[] s)
        {
            int maxRecordBreaks = 0;
            int minRecordBreaks = 0;
            int maxRecord = s[0];
            int minRecord = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (maxRecord < s[i])
                {
                    maxRecord = s[i];
                    maxRecordBreaks++;
                }
                else if (minRecord > s[i])
                {
                    minRecord = s[i];
                    minRecordBreaks++;
                }
            }
            int[] results = { maxRecordBreaks, minRecordBreaks };
            return results;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
