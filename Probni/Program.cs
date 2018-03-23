using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probni
{
    public class Thing
    {
    }

    public class Animal : Thing
    {
        public int Weight;
    }

    public class Vegetable : Thing
    {
        public int Length;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Program asd = new Program();
            asd.Go();
        }
        public void Go()
        {
            Thing x = new Animal();
            Switcharoo(x);
            Console.WriteLine(
              "x is Animal    :   "
              + (x is Animal).ToString());
            Console.WriteLine(
                "x is Vegetable :   "
                + (x is Vegetable).ToString());
        }
        public void Switcharoo( Thing pValue)
        {
            pValue = new Vegetable();
        }
    }
}
