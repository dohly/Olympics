using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1563
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> magazines=new List<string>();
            int bayan = 0;
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                if (magazines.Any(x => x == s))
                {
                    bayan++;
                }
                else
                {
                    magazines.Add(s);
                }
            }
            Console.WriteLine(bayan);
        }
    }
}
