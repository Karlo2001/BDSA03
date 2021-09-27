using System;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        public delegate string PrintReverse(string input);
        public delegate decimal Product(decimal a, decimal b);
        public delegate bool EqualNumber(string a, int b);

        [Theory]
        [InlineData("aab", "baa")]
        [InlineData("Reverse this string", "gnirts siht esreveR")]
        public void printReverse(string input, string expected)
        {
            var printReverseDelegate = new PrintReverse(
            delegate (string input)
            {
                char[] inputCharArray = input.ToCharArray();
                Array.Reverse(inputCharArray);
                var reversedString = new string(inputCharArray);
                Console.WriteLine(reversedString);
                return reversedString;

            }
        );
            PrintReverse del = printReverseDelegate;
            var res = del(input);
            
            Assert.Equal(expected, res);

        }
        [Theory]
        [InlineData(2, 2, 4)]
        public void Product_Test(decimal a, decimal b, decimal expected)
        {
            Product product = (decimal a, decimal b) => a * b;

            var res = product(a,b);

            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(" 0042", 42, true)]
        public void EqualNumber_Test(string a, int b, bool expected)
        {
            EqualNumber isEqual = (string a, int b) => Int64.Parse(a) == b;

            var res = isEqual(a,b);

            Assert.Equal(expected, res);
        }
    }
}