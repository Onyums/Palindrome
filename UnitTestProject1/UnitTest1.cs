
using palindrome;
using Xunit;

namespace UnitTestProject1
{
    
    public class UnitTest2
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
