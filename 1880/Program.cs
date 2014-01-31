using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1880
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1=int.Parse(Console.ReadLine());
            HashSet<string> min = null;
            var list = new HashSet<string>(Console.ReadLine().Split());
            int N2=int.Parse(Console.ReadLine());
            var list2 = new HashSet<string>(Console.ReadLine().Split());
            min = list;
            if (N2 < N1)
            {
                min = list2;
            }
            int N3=int.Parse(Console.ReadLine());
            var list3 = new HashSet<string>(Console.ReadLine().Split());
            if (N3 < min.Count)
            {
                min = list3;
            }
            int count= min.Count(s => list2.Contains(s) && list3.Contains(s));
            Console.WriteLine(count);
        }
    }
}
