using System;
using System.Diagnostics;

namespace inluppg6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 1;
            int tal2 = 2;

            Console.WriteLine(Störst(tal1, tal2));
        }

        static int Störst(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else if (y > x)
            {
                return y;
            }
            return x;
        }
    }
}