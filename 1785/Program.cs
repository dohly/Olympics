using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1785
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> words = new Dictionary<int, string>()
                {
                    {1,"few"},
                    {5,"several"},
                    {10,"pack"},
                    {20,"lots"},
                    {50,"horde"},
                    {100,"throng"},
                    {250,"swarm"},
                    {500,"zounds"},
                    {1000,"legion"}
                };
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(words.Last(x=>x.Key<=N).Value);
        }
    }
}
