using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1100
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<int, int> commands = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                var inputs = s.Split(new string[] { " " }, StringSplitOptions.None);
                commands.Add(int.Parse(inputs[0]), int.Parse(inputs[1]));
            }
            foreach (var command in commands.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} {1}", command.Key, command.Value);
            }
        }
    }
}
