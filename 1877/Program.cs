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
            int max = N1 > N2 ? N1 : N2;
            int code = 0;
            int codeVelo = N1;
            while (code<=max)
            {
                if (code == codeVelo)
                {
                    Console.WriteLine("Yes");
                    return;
                }
                if (codeVelo == N1)
                {
                    codeVelo = N2;
                }
                else
                {
                    codeVelo = N1;
                }
                code++;
            }
            Console.WriteLine("No");
        }
    }
}
