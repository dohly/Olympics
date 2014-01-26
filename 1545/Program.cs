using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1545
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> ie=new List<string>();
            for (int i = 0; i < N; i++)
            {
                ie.Add(Console.ReadLine());
            }
            string k = Console.ReadLine();
            ie = ie.Where(x => x.StartsWith(k)).ToList();
            if (ie.Count != 0)
            {
                foreach (string s in ie)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
