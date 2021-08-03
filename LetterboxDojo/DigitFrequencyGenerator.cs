using System;

namespace LetterboxDojo
{
    public class DigitFrequencyGenerator
    {
        public static int[] digitFrequency(int startNumber, int endNumber)
        {
            var array = new int[10];

            for (int i = startNumber; i <= endNumber; i++)
            {
                array[i%10] = 1;
            }

            return array;
        }
    }
}
