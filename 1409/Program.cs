using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1409
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("{0} {1}", inp[1] - 1, inp[0] - 1);
        }
    }
}
