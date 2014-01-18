using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1293
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inputs = input.Split(new string[] {" "}, StringSplitOptions.None);
            int N = int.Parse(inputs[0]);
            int A = int.Parse(inputs[1]);
            int B = int.Parse(inputs[2]);
            Console.WriteLine(N*A*B*2);
        }
    }
}
