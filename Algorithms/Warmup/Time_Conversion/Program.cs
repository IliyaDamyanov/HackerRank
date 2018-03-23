using System;

namespace Time_Conversion
{
    public class Program
    {
        static string timeConversion(string s)
        {
            string result = string.Empty;
            if (s.Substring(8,2)=="AM")
            {
                result = s.Substring(0, 8);
                if (s == "12:00:00AM")
                {
                    result = "00:00:00";
                }
                if (s.Substring(0,2)=="12")
                {
                    result = "00" + s.Substring(2, 6);
                }
            }
            else if (s.Substring(8, 2) == "PM")
            {
                string hoursInString = string.Format($"{s[0]}{s[1]}");
                int hours = int.Parse(hoursInString);
                hours += 12;
                if (hours > 23)
                {
                    hours -= 12;
                }
                result = hours + s.Substring(2, 6);
            }
            return result;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);

        }
    }
}
