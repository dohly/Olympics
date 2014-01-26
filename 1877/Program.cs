using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1877
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            if (N1 % 2 == 0 && N2%2!=0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
