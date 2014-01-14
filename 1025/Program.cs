using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1025
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupCount = double.Parse(Console.ReadLine());
            string groupStr = Console.ReadLine();
            var groups =
                groupStr.Split(new string[] {" "}, StringSplitOptions.None).Select(x => int.Parse(x)).OrderBy(x=>x).ToArray();
            int greatGroupsCount = Convert.ToInt32(Math.Ceiling(groupCount/2));
            int count = 0;
            double sum = 0;
            foreach (int gr in groups)
            {
                double people = gr;
                sum+=Math.Ceiling(people/2);
                count++;
                if (count == greatGroupsCount)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
