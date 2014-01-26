using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1567
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> keyboard = new List<string>()
                {
                    "abc","def","ghi","jkl","mno","pqr","stu","vwx","yz",
                    ".,!"," "
                };
            string s = Console.ReadLine();
            int i = 0;
            foreach (var ch in s)
            {
                var k = keyboard.Select(x => x.IndexOf(ch)).FirstOrDefault(x => x != -1);
                i = i + (k + 1);
            }
            Console.WriteLine(i);
        }
    }
}
