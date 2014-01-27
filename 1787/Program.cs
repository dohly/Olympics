using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1787
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int k = i[0];
            i = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int probka = 0;
            foreach (int j in i)
            {
                probka += j - k;
                if (probka < 0)
                {
                    probka = 0;
                }
            }
            Console.WriteLine(probka);
        }
    }
}
