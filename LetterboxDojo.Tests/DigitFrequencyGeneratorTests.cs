using System;
using Xunit;

namespace LetterboxDojo.Tests
{
    public class DigitFrequencyGeneratorTests
    {
        [Fact]
        public void ReturnTypeIsTenDigitsArray()
        {
            int[] number = DigitFrequencyGenerator.digitFrequency(10,20);
            Assert.Equal(10, number.Length);
        }

        // starting at 0 is out of the spec!
        //[InlineData(0, 0, new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 })]
        [Theory]
        [InlineData(1, 1, new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 })]
        [InlineData(1, 2, new int[] { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 })]
        [InlineData(1, 9, new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
        [InlineData(1, 10, new int[] { 1, 2, 1, 1, 1, 1, 1, 1, 1, 1 })]
        public void WhenStartAndEndThenExpectedMatches(
                int start, int end, int[] expected)
        {
            int[] actual = DigitFrequencyGenerator.digitFrequency(start, end);
            Assert.Equal(expected, actual);
        }
    }
}
