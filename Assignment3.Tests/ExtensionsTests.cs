using System;
using Xunit;
using BDSA2020.Assignment03;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        var test1 = new Uri("https://test.com");
        var test2 = new Uri("www.test.com");
        [Theory]
        [InlineData(test1, true)]
        [InlineData(test2, false)]
        public void IsSecure_Returns_True_If_HTTPS(Uri input, bool expected)
        {
            var res = input.IsSecure();

            Assert.Equal(expected, res);
        }
    }
}
