using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        //Add this to the final PDF and delete here
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> input) => input.SelectMany(x => x).ToList();
        public static int[] DivisibleAndGreater(this int[] input) => input.Where(x => x > 42 && x % 7 == 0).ToArray();
        public static int[] LeapYears(this int[] input) => input.Where(x => x % 4 == 0 && (x % 100 != 0 || x % 400 == 0)).ToArray();

        public static bool IsSecure(this Uri input) => input.Scheme == Uri.UriSchemeHttps;

        public static int WordCount(this string input)
        {
            string[] splitted = input.Split(" ");
            var pattern = @"^([a-zA-Z]||-)+(,||:||;)?$";
            Regex rgx = new Regex(pattern);
            int count = 0;
            foreach (string word in splitted)
            {
                MatchCollection mtchCol = rgx.Matches(word);
                if (mtchCol.Count > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static List<String> AllRowling(this IReadOnlyCollection<Wizard> input)
        {
            List<String> resList = new List<String>();
            foreach(var wiz in input)
            {
                if (wiz.Creator == "J.K. Rowling")
                {
                    resList.Add(wiz.Name);
                }
            }
            return resList;
        }   
        public static int? FirstSithLord(this IReadOnlyCollection<Wizard> input)
        {
            int? year = null;
            foreach (var wiz in input)
            {
                if (wiz.Name.Contains("Darth"))
                {
                    year = wiz.Year;
                }
            }
            return year;
        }

        public static List<(string, int?)> UniqueWizardList(this IReadOnlyCollection<Wizard> input)
        {
            List<(string Name, int? Year)> resList = new List<(string, int?)>();
            foreach (var wiz in input)
            {
                if (resList.Contains((wiz.Name, wiz.Year)))
                {
                    continue;
                }
                resList.Add((wiz.Name, wiz.Year));
            }
            return resList;
        }
    }
}
