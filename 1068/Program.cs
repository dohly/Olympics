using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1068
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            decimal inc = 1;
            int count = N;
            if (N <= 0)
            {
                inc = -1;
                count = Math.Abs(N)+2;
            }
            decimal sum = 2 + (count-1)*inc;
            sum = sum/2;
            sum = sum*count;
            int s = Convert.ToInt32(sum);
            Console.WriteLine(s);
        }
    }
}
