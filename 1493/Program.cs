using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1493
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var a = s.Substring(0, 3).Select(x => Char.GetNumericValue(x)).Sum();
            var b = int.Parse(s.Substring(3));
            b++;
            double a2 = b.ToString().Select(x => Char.GetNumericValue(x)).Sum();
            if (a2 == a)
            {
                Console.WriteLine("Yes");
                return;
            }
            b = b - 2;
            a2 = b.ToString().Select(x => Char.GetNumericValue(x)).Sum();
            if (a2 == a)
            {
                Console.WriteLine("Yes");
                return;
            }
            Console.WriteLine("No");
        }
    }
}
