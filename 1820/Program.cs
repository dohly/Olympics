using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1820
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] i = Console.ReadLine().Split().Select(x => float.Parse(x)).ToArray();
            float n = i[0];
            float k = i[1];
            if (k >= n)
            {
                Console.WriteLine(2);
                return;
            }
            double result = Math.Ceiling(n/k*2);
            Console.WriteLine(result);
        }
    }
}
