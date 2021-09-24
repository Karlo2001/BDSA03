using System;
using System.Linq;
using System.Collections.Generic;
using BDSA2020.Assignment03;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IEnumerable<int>> xs = new List<List<int>> {new List<int>{1,2,3,4}, new List<int>{1,2,3,4}};
            IEnumerable<int> result = xs.Flatten();
            int[] ys = new int[] {49,1,2,3,4,5,6};
            int[] res = ys.DivisibleAndGreater();
            int[] ys2 = new int[]{2000, 2004, 2008, 100, 200, 1700, 1600};
            int[] res2 = ys2.LeapYears();
        }
    }
}
