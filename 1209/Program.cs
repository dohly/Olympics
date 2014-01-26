using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1209
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int d = int.Parse(Console.ReadLine());
                int j = 0;
                if ((1 + Math.Sqrt(1 + 8.0*d - 8))%2 == 0)
                {
                    j = 1;
                }
                Console.Write("{0} ", j);
            }
        }
    }
}
