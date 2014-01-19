using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1264
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(inp[0]*(inp[1]+1));
        }
    }
}
