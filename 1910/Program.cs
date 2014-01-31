using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1910
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            int max = 0;
            int index = -1;
            for (int i = 0; i < arr.Count-2; i++)
            {
                int sum = arr[i] + arr[i + 1] + arr[i + 2];
                if (max < sum)
                {
                    max = sum;
                    index = i + 1;
                }
            }
            Console.WriteLine("{0} {1}",max,index+1);

        }
    }
}
