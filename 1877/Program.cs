using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1877
{
    class Program
    {
        static bool CanCrack(int cracker, ref int code)
        {
            if (cracker > code)
            {
                return false;
            }
            if (cracker == code)
            {
                return true;
            }
            return CanCrack(cracker + 2, ref code);
        }
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            if (CanCrack(0, ref N1) || CanCrack(1, ref N2))
            {
                Console.WriteLine("yes");
                return;
            }
            Console.WriteLine("no");
        }
    }
}
