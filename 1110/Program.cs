using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _1110
{
    class Program
    {
        static bool IsCorrect(int X, int N, int M, int Y)
        {
            var pow = new BigInteger(X);
            var left = BigInteger.ModPow(pow, N, M);
            return left == new BigInteger(Y);
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var inputs = s.Split(new string[] { " " }, StringSplitOptions.None);
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int Y = int.Parse(inputs[2]);
            var range = Enumerable.Range(0, M - 1);
            var result = range.Where(x => IsCorrect(x, N, M, Y)).ToList();
            if (result.Count == 0)
            {
                Console.WriteLine(-1);
            }
            s = string.Join(" ", result);
            Console.WriteLine(s);
        }
    }
}
