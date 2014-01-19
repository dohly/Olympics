using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1196
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> teacher = new HashSet<string>();
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                if (!teacher.Contains(s))
                {
                    teacher.Add(s);
                }
            }
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < M; i++)
            {
                string s = Console.ReadLine();
                if (teacher.Contains(s))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
