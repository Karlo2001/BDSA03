using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_2_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(10, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Gandalf", "Lord of the Rings",1955,"J.R.R. Tolkien")]
        [InlineData("Dumbledore", "Harry Potter", 1997, "J.K. Rowling")]
        [InlineData("Darth Maul", "Star Wars", 1977, "George Lucas")]
        [InlineData("Hermione Granger", "Harry Potter", 1997, "J.K. Rowling")]
        [InlineData("Ron Weasley", "Harry Potter", 1997, "J.K. Rowling")]
        [InlineData("Harry Potter", "Harry Potter", 1997, "J.K. Rowling")]
        [InlineData("Palpatine", "Star Wars", 1977, "George Lucas")]
        [InlineData("Voldemort", "Harry Potter", 1997, "J.K. Rowling")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
        
    }
}

