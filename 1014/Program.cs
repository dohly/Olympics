using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1014
{
    class Program
    {
        private static Dictionary<int, int> digits = new Dictionary<int, int>()
            {
                {2,0},
                {3,0},
                {5,0},
                {7,0}
            };
        static bool FindDigits(int n)
        {
            if (n == 1)
            {
                return true;
            }
            int d = digits.FirstOrDefault(x => n % x.Key == 0).Key;
            if (d == 0)
            {
                return false;
            }
            digits[d]++;
            n = n / d;
            return FindDigits(n);
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 0)
            {
                Console.WriteLine(10);
                return;
            }
            else if (N < 10)
            {
                Console.WriteLine(N);
                return;
            }
            if (FindDigits(N))
            {
                digits[9] = digits[3] / 2;
                if (digits[9] > 0)
                {
                    digits[3] = digits[3] % 2;
                }
                digits[8] = digits[2] / 3;
                if (digits[8] > 0)
                {
                    digits[2] = digits[2] % 3;
                }
                digits[6] = digits[3]>digits[2]?digits[2]:digits[3];
                if (digits[6] != 0)
                {
                    digits[2] = digits[2] - digits[6];
                    digits[3] = digits[3] - digits[6];
                }
                digits[4] = digits[2] / 2;
                if (digits[4] > 0)
                {
                    digits[2] = digits[2] % 2;
                }
                string s = "";
                for (int i = 2; i < 10; i++)
                {
                    if (digits[i] > 0)
                    {
                        s = s + string.Join("", Enumerable.Repeat(i, digits[i]));
                    }

                }
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
