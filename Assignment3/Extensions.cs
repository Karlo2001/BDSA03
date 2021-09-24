using System;
using System.Linq;
using System.Collections.Generic;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> input) => input.SelectMany(x => x).ToList();
        public static int[] DivisibleAndGreater(this int[] input) => input.Where(x => x > 42 && x % 7 == 0).ToArray();
        public static int[] LeapYears(this int[] input) => input.Where(x => x % 4 == 0 && (x % 100 != 0 || x % 400 == 0)).ToArray();
        public static bool IsSecure(this Uri input) => input.Scheme == Uri.UriSchemeHttps;
    }
}
