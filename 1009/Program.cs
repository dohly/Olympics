using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] a = new int[18];
            a[0] = 0;
            K = K - 1;
            a[1] = K;
            for (int j = 2; j < N+1; j++)
            {
                //modified fibonacci
                a[j] = a[j - 2]*(K) + a[j - 1]*K;
            }
            Console.WriteLine(a[N]+a[N-1]);

        }
    }
}
