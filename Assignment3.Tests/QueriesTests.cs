using System;
using Xunit;
using BDSA2020.Assignment03;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {

        [Theory]
        [InlineData("Hermione Granger")]
        [InlineData("Ron Weasley")]
        [InlineData("Harry Potter")]
        [InlineData("Voldemort")]
        [InlineData("Dumbledore")]
        public void AllRowling_Test(string name)
        {
            var wizards = Wizard.Wizards.Value;

            var res = wizards.AllRowling();

             Assert.Contains(res, w =>
                w == name
            );
        }
        [Fact]
        public void Amount_AllRowling_Test()
        {
            var wizards = Wizard.Wizards.Value;

            var res = wizards.AllRowling();

            Assert.Equal(6, res.Count);
        }

        /*[Fact]
        public void Rowling_Wizards_return_name_linq()
        {
            var wizards = Wizard.Wizards.Value;

            var res = wizards.

            Assert.Equal();
        }*/
        [Fact]
        public void First_Sith_Lord_Year_Test()
        {
            var wizards = Wizard.Wizards.Value;

            var res = wizards.FirstSithLord();

            Assert.Equal(1977, res);
        }

        [Theory]
        [InlineData("Hermione Granger")]
        [InlineData("Ron Weasley")]
        [InlineData("Harry Potter")]
        [InlineData("Voldemort")]
        [InlineData("Dumbledore")]
        public void Unique_Wizard_List_Test(string name)
        {
            var wizards = Wizard.Wizards.Value;
            var count = 0;

            var res = wizards.UniqueWizardList();

            foreach (var wiz in res)
            {
                if (wiz.Name == name)
                {
                    count++;
                }
            }

            Assert.Equal(1, count);
        }

        [Fact]
        public void Grouped_And_Sorted_Wizards_Test()
        {
            var wizards = Wizard.Wizards.Value;
            var expected = new List<string> {"Gandalf", "Dumbledore", "Darth Maul"};

            var res = wizards.GroupedAndSortedWizards();

            Assert.Equal(expected, res);
        }
        [Fact]
        public void Grouped_And_Sorted_Wizards_Test_LINQ()
        {
            var wizards = Wizard.Wizards.Value;
            var expected = new List<string> {"Gandalf", "Dumbledore", "Darth Maul"};

            var res = Queries.GroupedAndOrderedListLINQ(wizards);

            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("Hermione Granger")]
        [InlineData("Ron Weasley")]
        [InlineData("Harry Potter")]
        [InlineData("Voldemort")]
        [InlineData("Dumbledore")]
        public void Unique_Wizard_List_Test_LINQ(string name)
        {
            var wizards = Wizard.Wizards.Value;
            var count = 0;

            var res = Queries.UniqueWizardListLINQ(wizards);

            foreach (var wiz in res)
            {
                if (wiz.Name == name)
                {
                    count++;
                }
            }

            Assert.Equal(1, count);
        }

        [Fact]
        public void First_Sith_Lord_Year_Test_LINQ()
        {
            var wizards = Wizard.Wizards.Value;

            var res = Queries.YearOfFirstSithLordLINQ(wizards);

            Assert.Equal(1977, res);
        }

        [Theory]
        [InlineData("Hermione Granger")]
        [InlineData("Ron Weasley")]
        [InlineData("Harry Potter")]
        [InlineData("Voldemort")]
        [InlineData("Dumbledore")]
        public void AllRowling_Test_LINQ(string name)
        {
            var wizards = Wizard.Wizards.Value;

            var res = Queries.AllRowlingLINQ(wizards);

            Assert.Contains(res, w =>
                            w == name);
        }

        [Fact]
        public void Amount_AllRowling_Test_LINQ()
        {
            var wizards = Wizard.Wizards.Value;

            var res = Queries.AllRowlingLINQ(wizards);

            Assert.Equal(6, res.Count());
        }
    }
}
