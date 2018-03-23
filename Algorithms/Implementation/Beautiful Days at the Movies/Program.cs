using System;
using System.Text;

namespace Beautiful_Days_at_the_Movies
{
    public class Program
    {
        static int beautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int l = i ; l <= j; l++)
            {
                string number = l.ToString();
                //string reversedNumberInString = string.Empty;
                StringBuilder reversedNumberInString = new StringBuilder();
                for (int m = number.Length-1; m >=0; m--)
                {
                    reversedNumberInString.Append(number[m]);
                    //reversedNumberInString += number[m];
                }
                int reversedNumber = int.Parse(reversedNumberInString.ToString());
                if (Math.Abs(l-reversedNumber)%k==0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(String[] args)
        {
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            int k = Convert.ToInt32(tokens_i[2]);
            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);
        }
    }
}
