using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_and_a_Mouse
{
    public class Program
    {
        static string[] catAndMouse(int x, int y, int z)
        {
            // Complete this function
            string[] finalString = new string[1];
            if (Math.Abs(x-z)<Math.Abs(y-z))
            {
                finalString[0] = "Cat A";
            }
            else if (Math.Abs(x - z) > Math.Abs(y - z))
            {
                finalString[0] = "Cat B";
            }
            else if (Math.Abs(x - z) == Math.Abs(y - z))
            {
                finalString[0] = "Mouse C";
            }
            return finalString;
        }

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]);
                int y = Convert.ToInt32(tokens_x[1]);
                int z = Convert.ToInt32(tokens_x[2]);
                string[] result = catAndMouse(x, y, z);
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
