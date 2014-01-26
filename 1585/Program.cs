using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1585
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> result = new Dictionary<string, int>()
                {
                    {"Emperor Penguin",0},
                    {"Macaroni Penguin",0},
                    {"Little Penguin",0}
                };
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                result[s]++;
            }
            var r=result.OrderByDescending(x => x.Value).First();
            Console.WriteLine(r.Key);
        }
    }
}
