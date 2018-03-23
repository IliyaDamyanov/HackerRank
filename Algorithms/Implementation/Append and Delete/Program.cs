using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_and_Delete
{
    class Program
    {
        static string appendAndDelete(string s, string t, int k)
        {
            int equalSimbols = 0;
            for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                if (s[i] == t[i])
                {
                    equalSimbols++;
                }
                else
                {
                    break;
                }
            }

            if (s.Length == t.Length && equalSimbols == s.Length)
            {
                return "Yes";
            }

            return string.Empty;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string result = appendAndDelete(s, t, k);
            Console.WriteLine(result);
        }
    }
}
