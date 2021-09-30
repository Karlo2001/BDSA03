using System.Linq;
using System;
using System.Collections.Generic;

namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> AllRowlingLINQ(IReadOnlyCollection<Wizard> input)
        {
            var names = from w in input
                        where w.Creator == "J.K. Rowling"
                        select w.Name;
            return names;
        }

        public static int? YearOfFirstSithLordLINQ(IReadOnlyCollection<Wizard> input)
        {
            var year = from w in input
                     where w.Name.Contains("Darth")
                     orderby w.Year ascending
                     select w.Year;
            return year.First();
        }

        public static IEnumerable<(string Name, int? Year)> UniqueWizardListLINQ(IReadOnlyCollection<Wizard> input)
        {
            var nameAndYear = from w in input
                            where w.Medium == "Harry Potter"
                            group w by new {w.Name, w.Year} into g
                            select (g.Key.Name, g.Key.Year);
            return nameAndYear;
        }

        public static IEnumerable<string> GroupedAndOrderedListLINQ(IReadOnlyCollection<Wizard> input)
        {
            var groupedAndOrdered = from w in input
                                    group w by w.Creator into g
                                    orderby g.Key descending, g.Select(x => x.Name)
                                    select g.Min(x => x.Name);
            return groupedAndOrdered;

        }
    }
}
