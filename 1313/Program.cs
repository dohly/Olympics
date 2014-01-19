using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1313
{
    class Program
    {
        static int GetStartIndex(int diagIndex, int N)
        {
            if (diagIndex <= N)
            {
                return diagIndex;
            }
            return N; 
        }
        static int GetEndIndex(int diagIndex, int N)
        {
            if (diagIndex <= N)
            {
                return 0;
            }
            return diagIndex - N;
        }
       
        
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[][] arr = new int[N][];
            for (int i = 0; i < N; i++)
            {
                arr[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            }
            int diagCount = N + (N - 1);
            for (int i = 0; i < diagCount; i++)
            {
                int r = GetStartIndex(i, N - 1);
                int c = GetEndIndex(i, N - 1);
                int er = GetEndIndex(i, N - 1);
                int ec = GetStartIndex(i, N - 1);
                do
                {
                    var d = arr[r][c];
                    Console.Write("{0} ",d);
                    if (r == er && c == ec) { break; }
                    r--;
                    c++;
                } while (true);
            }

        }
    }
}
