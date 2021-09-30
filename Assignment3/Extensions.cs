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
                if ((wiz.Name.Contains("Darth") && wiz.Year < year) || year == null)
                {
                    year = wiz.Year;
                }
            }
            return year;
        }

        public static List<(string Name, int? Year)> UniqueWizardList(this IReadOnlyCollection<Wizard> input)
        {
            List<(string Name, int? Year)> resList = new List<(string, int?)>();
            foreach (var wiz in input)
            {
                if (resList.Contains((wiz.Name, wiz.Year)) || wiz.Medium != "Harry Potter")
                {
                    continue;
                }
                resList.Add((wiz.Name, wiz.Year));
            }
            return resList;
        }

        public static List<string> GroupedAndSortedWizards(this IReadOnlyCollection<Wizard> input)
        {
            List<string> wizNameList = new List<string>();
            List<string> wizCreatorList = new List<string>();
            foreach (var wiz in input)
            {
                bool added = false;
                var index = 0;
                if (!wizCreatorList.Contains(wiz.Creator))
                {
                    wizNameList.Add(wiz.Name);
                    wizCreatorList.Add(wiz.Creator);
                    added = true;
                    index = wizNameList.Count - 1;
                } else {
                    index = wizNameList.Count;
                }
                
                while(index - 1 >= 0)
                {
                    var prevIndex = index - 1;

                    if (wizCreatorList[prevIndex] == wiz.Creator)
                    {
                        if (string.Compare(wizNameList[prevIndex], wiz.Name) == 1)
                        {
                            wizNameList[prevIndex] = wiz.Name;
                        }
                        break;
                    }
                    if (added)
                    {
                        if (string.Compare(wizCreatorList[prevIndex], wizCreatorList[index]) == -1)
                        {
                            var temp = wizCreatorList[prevIndex];
                            var temp2 = wizNameList[prevIndex];
                            wizCreatorList[prevIndex] = wizCreatorList[index];
                            wizNameList[prevIndex] = wizNameList[index];
                            wizCreatorList[index] = temp;
                            wizNameList[index] = temp2;
                        } else {
                            break;
                        }
                    }
                    index--;
                }
            }
            return wizNameList;
        }
    }
}
