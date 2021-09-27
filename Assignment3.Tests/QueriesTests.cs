using System;
using Xunit;
using BDSA2020.Assignment03;
using System.Collections.Generic;
using Linq;

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

            Assert.Equal(5, res.Count);
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

        [Fact]
        public void Unique_Wizard_List_Test()
        {
            var wizards = Wizard.Wizards.Value;

            var res = wizards.UniqueWizardList();

            Assert.Contains(res, w =>
                w.Name == name &&
                w.Year == year);
        }
    }
}
