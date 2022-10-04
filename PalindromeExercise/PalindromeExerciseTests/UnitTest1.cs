using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void IsAPalindrome_Test(string word, bool expected)
        {
            var wordsmith = new WordSmith();
            var actual = wordsmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
