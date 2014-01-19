using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1319
{
    internal class Program
    {
        private static int GetStartIndex(int diagIndex, int N)
        {
            if (diagIndex <= N)
            {
                return diagIndex;
            }
            return N;
        }

        private static int GetEndIndex(int diagIndex, int N)
        {
            if (diagIndex <= N)
            {
                return 0;
            }
            return diagIndex - N;
        }


        private static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] arr = new int[N,N];
            int diagCount = N + (N - 1);
            int d = 0;
            for (int i = 0; i < diagCount; i++)
            {
                int r = GetStartIndex(i, N - 1);
                int c = GetEndIndex(i, N - 1);
                int er = GetEndIndex(i, N - 1);
                int ec = GetStartIndex(i, N - 1);
                do
                {
                    d++;
                    arr[r, c] = d;
                    if (r == er && c == ec)
                    {
                        break;
                    }
                    r--;
                    c++;
                } while (true);
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ",arr[N-j-1,i]);
                }
                Console.WriteLine();
            }
        }
    }
}
