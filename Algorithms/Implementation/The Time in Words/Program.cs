using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Time_in_Words
{
    public class Program
    {
        static string timeInWords(int h, int m)
        {
            if (h == 12 && m > 30)
            {
                h = 0;
            }
            string minutesString = string.Empty;
            if (m < 30)
            {
                minutesString = MinutesToString(m);
            }
            else if (m>30 )
            {
                minutesString = MinutesToString(60 - m);
            }
            if (m == 00)
            {
                return $"{HoursString(h)} o'clock";
            }
            else if (m==01)
            {
                return $"one minute past {HoursString(h)}";
            }
            else if (m == 59)
            {
                return $"one minute to {HoursString(h+1)}";
            }
            else if (m == 15)
            {
                return $"quarter past {HoursString(h)}";
            }
            else if (m < 30)
            {
                return $"{minutesString} past {HoursString(h)}";
            }
            else if (m == 30)
            {
                return $"half past {HoursString(h)}";
            }
            else if (m == 45)
            {
                return $"quarter to {HoursString(h + 1)}";
            }
            else if (m > 30)
            {
                return $"{minutesString} to {HoursString(h)+1}";
            }

            return string.Empty;
        }

        static void Main()
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            string result = timeInWords(h, m);
            Console.WriteLine(result);
        }

        public static string HoursString(int h)
        {
            string hoursString = string.Empty;
            switch (h)
            {
                case 1: hoursString = "one"; break;
                case 2: hoursString = "two"; break;
                case 3: hoursString = "three"; break;
                case 4: hoursString = "four"; break;
                case 5: hoursString = "five"; break;
                case 6: hoursString = "six"; break;
                case 7: hoursString = "seven"; break;
                case 8: hoursString = "eight"; break;
                case 9: hoursString = "nine"; break; ;
                case 10: hoursString = "ten"; break;
                case 11: hoursString = "eleven"; break;
                case 12: hoursString = "twelve"; break;
                default: throw new ArgumentException("second digit string");
            }

            return hoursString;
        }

        public static string MinutesToString(int minutes)
        {
            string firstDigitInWordsFromMinutesString = CalculateFirstDigitFromMinutesString(minutes % 10);
            string secondDigitFromMinutesString = CalculateSecondDigitFromMinutesString(minutes / 10);
            string minutesString =string.Empty;
            if (minutes < 10)
            {
                minutesString = firstDigitInWordsFromMinutesString;
            }
            if (minutes == 10)
            {
                minutesString = "ten";
            }
            if (minutes == 11)
            {
                minutesString = "eleven";
            }
            else if (minutes == 12)
            {
                minutesString = "twelve";
            }
            else if (minutes >= 13 && minutes < 20)
            {
                minutesString = $"{firstDigitInWordsFromMinutesString}{secondDigitFromMinutesString}";
            }
            else if (minutes >= 20 && minutes < 60)
            {
                minutesString = $"{secondDigitFromMinutesString}{firstDigitInWordsFromMinutesString}";
            }

            return minutesString;
        }

        public static string CalculateFirstDigitFromMinutesString(int digit)
        {
            string digitString = string.Empty;
            switch (digit)
            {
                case 1: digitString = "teen"; break;
                case 2: digitString = "twenty"; break;
                case 3: digitString = "thirty"; break;
                case 4: digitString = "forty"; break;
                case 5: digitString = "fifty"; break;
                default: throw new ArgumentException("second digit string");
            }

            return digitString;
        }

        public static string CalculateSecondDigitFromMinutesString(int digit)
        {
            string digitString = string.Empty;
            switch (digit)
            {
                case 0: digitString = ""; break;
                case 1: digitString = "one"; break;
                case 2: digitString = "two"; break;
                case 3: digitString = "three"; break;
                case 4: digitString = "four"; break;
                case 5: digitString = "five"; break;
                case 6: digitString = "six"; break;
                case 7: digitString = "seven"; break;
                case 8: digitString = "eight"; break;
                case 9: digitString = "nine"; break;
                default: throw new ArgumentException("second digit string");
            }

            return digitString;
        }
    }
}
