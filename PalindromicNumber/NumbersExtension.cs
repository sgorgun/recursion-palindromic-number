using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} is less than zero.", nameof(number));
            }

            int tempNumber = ReverseNumber(number, 0);
            return tempNumber == number;
        }

        private static int ReverseNumber(int number, int tempNumber)
        {
            if (number == 0)
            {
                return tempNumber;
            }

            tempNumber = (tempNumber * 10) + (number % 10);
            return ReverseNumber(number / 10, tempNumber);
        }
    }
}
