using System;
namespace BasicSorting_Yagnik_007
{
    /// <summary>
    /// class which contains validation methods
    /// </summary>
    class ValidationClass
    {
        /// <summary>
        /// Method to validate user input
        /// </summary>
        /// <param name="input">User input</param>
        /// <param name="minRange">Maximum range acceptable for input</param>
        /// <param name="maxRange">Maximum range acceptable for input</param>
        /// <returns>true or false for validation</returns>
        public static bool ValidateDecimalInput(string input, decimal minRange, decimal maxRange)
        {
            decimal value;
            if (decimal.TryParse(input, out value) == false)
            {
                Console.WriteLine(DisplayMessage.FormatExceptionmessage);
                return false;
            }
            else if ((value < minRange) == true)
            {
                Console.WriteLine(DisplayMessage.NagetiveNumberExceptionMessage);
                return false;
            }
            else if ((value > maxRange) == true)
            {
                Console.WriteLine(DisplayMessage.LargeIndexNumberExceptionMessage);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method to validate user input
        /// </summary>
        /// <param name="input">User input</param>
        /// <param name="minRange">Minimum range acceptable for input</param>
        /// <param name="maxRange">Maximum range acceptable for input</param>
        /// <returns>true or false for validation</returns>
        public static bool ValidateIntInput(string input, int minRange, int maxRange)
        {
            int value;
            if (int.TryParse(input, out value) == false)
            {
                Console.WriteLine(DisplayMessage.FormatExceptionmessage);
                return false;
            }
            else if ((value < minRange) == true)
            {
                Console.WriteLine(DisplayMessage.NagetiveNumberExceptionMessage);
                return false;
            }
            else if ((value > maxRange) == true)
            {
                Console.WriteLine(DisplayMessage.LargeIndexNumberExceptionMessage);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}