using System;
using Xunit;
using BDSA2020.Assignment03;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        
        
        [Fact]
        public void IsSecure_Returns_True_For_HTTPS()
        {
            var input = new Uri("https://test.com");

            var res = input.IsSecure();

            Assert.True(res);
        }
        [Fact]
        public void IsSecure_Returns_False_For_Non_HTTPS()
        {
            var input = new Uri("http://www.test.com");

            var res = input.IsSecure();

            Assert.False(res);
        }

        [Theory]
        [InlineData("This string contains 8 words, and one number : as7dx abcd-dxcd)", 8)]
        public void WordCount(string input, int expected)
        {
            var res = input.WordCount();

            Assert.Equal(expected, res);
        }
    }
}
