using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1327
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = A; i < B+1; i++)
            {
                if (i%2 != 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
