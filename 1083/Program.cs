using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1083
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inputs = input.Split(new string[] {" "}, StringSplitOptions.None);
            int N = int.Parse(inputs[0]);
            int K = inputs[1].Length;
            long result = 1;
            var ost = N % (double)K;
            if (ost == 0)
            {
                ost = K;
            }
            int i = 1;
            while (N>ost)
            {
                result = result*N;
                N = N - i * K;
            }
            result = (long) (result*ost);
            Console.WriteLine(result);
        }
    }
}
