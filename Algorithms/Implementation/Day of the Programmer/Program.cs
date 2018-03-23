using System;

namespace Day_of_the_Programmer
{
    public class Program
    {
        static string solve(int year)
        {
            string date = string.Empty;
            // Complete this function
            if (year<1918)
            {
                if (year%4==0)
                {
                    date = "12.09." + year;
                }
                else
                {
                    date = "13.09." + year;
                }
            }
            if (year>1918)
            {
                if (year % 4 == 0)
                {
                    if (year % 400 == 0)
                    {
                        date = "12.09." + year;
                    }
                    else if (year % 100 == 0)
                    {
                        date = "13.09." + year;
                    }
                    else
                    {
                        date = "12.09." + year;
                    }                
                }
                else
                {
                    date = "13.09." + year;
                }
            }
            if (year==1918)
            {
                date = "26.09.1918";
            }
            return date;
        }

        static void Main()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string result = solve(year);
            Console.WriteLine(result);
        }
    }
}
