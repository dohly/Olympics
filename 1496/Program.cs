using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1496
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();
            List<string> accounts = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                if (accounts.Any(x => x == s) && result.All(x => x != s))
                {
                    result.Add(s);
                }
                else
                {
                    accounts.Add(s);
                }
            }
            foreach (var VARIABLE in result)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
