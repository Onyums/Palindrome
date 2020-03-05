using palindrome;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        public void PalindromeTester(string word, bool expected)
        {
            //act
            var actual = stitic.Check(word);

            //assert

            Xunit.Assert.Equal(expected, actual);

        }
    }
}
