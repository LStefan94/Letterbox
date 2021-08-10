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
        
        [Fact]
        public void OneToOneTestCase() 
        {
            int[] actual = DigitFrequencyGenerator.digitFrequency(1,1);
            Assert.Equal(new int[] {0,1,0,0,0,0,0,0,0,0}, actual);
        }

        [Fact]
        public void ZeroToZeroTestCase()
        {
            int[] actual = DigitFrequencyGenerator.digitFrequency(0, 0);
            Assert.Equal(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, actual);
        }
    }
}