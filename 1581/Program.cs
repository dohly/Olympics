using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1581
{
    class KVP
    {
        public string S { get; set; }
        public int Count { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<KVP> result = new List<KVP>();
            Console.ReadLine();
            var input = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                string s = input[i];
                KVP kvp = result.LastOrDefault();
                if (kvp == null || kvp.S != s)
                {
                    kvp = new KVP() { S = s };
                    result.Add(kvp);
                }
                kvp.Count++;
            }
            string res = "";
            foreach (KVP kvp in result)
            {
                res = res + string.Format("{0} {1} ", kvp.Count, kvp.S);
            }
            Console.WriteLine(res);

        }
    }
}
