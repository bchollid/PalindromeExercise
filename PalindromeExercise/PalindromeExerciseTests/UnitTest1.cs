using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mom", true)]
        [InlineData("civic", true)]
        [InlineData("computer", false)]
        [InlineData("video", false)]
        [InlineData("keyboard", false)]
        public void PalindromeTest(string word, bool expected)
        {
            var newWordSmith = new WordSmith();

            bool actual = newWordSmith.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
