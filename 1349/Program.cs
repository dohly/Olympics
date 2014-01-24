using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1349
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "1": Console.WriteLine("1 2 3");
                    break;
                case "2":Console.WriteLine("3 4 5");
                    break;
                default:Console.WriteLine(-1);
                    break;
            }
        }
    }
}
